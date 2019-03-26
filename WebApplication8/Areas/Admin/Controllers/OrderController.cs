using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using WebApplication8.Models.WebShop;
using WebApplication8.Models.CustomerViewModels;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class OrderController : AdminController
    {
        WebShopContext db ;
        public OrderController(WebShopContext _db) {
            db = _db;
        }
        [Area("Admin")]
        public ActionResult Index()
        {
            var orders = db.Orders.Include(u => u.Customer).Include(u => u.OrderDetails).Where(u=>u.Status == 0).ToList();
            ViewBag.DateStart = "";
            ViewBag.DateEnd = "";
            ViewBag.Status = "";
            var order_search = new SearchOrderView();
            if (!string.IsNullOrEmpty(Request.Query["status"].ToString())) {
                // var a = "abc";
                ViewBag.Status = Request.Query["status"].ToString();
                order_search.Status = int.Parse(Request.Query["status"].ToString());
                orders = db.Orders.Include(u => u.Customer).Include(u => u.OrderDetails).Where(x=>x.Status == int.Parse(Request.Query["status"].ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(Request.Query["datestart"].ToString()))
            {
                // var a = "abc";
                ViewBag.DateStart = Request.Query["datestart"].ToString();
                order_search.DateStart= Request.Query["datestart"].ToString();
                orders = orders.Where(x => x.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["datestart"].ToString()) >= 0).ToList();
            }
            if (!string.IsNullOrEmpty(Request.Query["dateend"].ToString()))
            {
                // var a = "abc";
                order_search.DateStart = Request.Query["dateend"].ToString();
                ViewBag.DateEnd = Request.Query["dateend"].ToString();
                orders =  orders.Where(x => x.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["dateend"].ToString()) < 0).ToList();
            }

            ViewBag.Orders = orders;
            return View(order_search);
        }

        [Area("Admin")]
        public ActionResult Detail(int id)
        {
            var order = db.Orders.Include(u=>u.Customer).Include(u=>u.OrderDetails).ThenInclude(a=>a.Product).SingleOrDefault(u=>u.Id==id);
            ViewBag.Total = order.Amount;
            return View(order);
        }
        [Area("Admin")]
        public ActionResult Delete(int id)
        {
            var order = db.Orders.SingleOrDefault(u => u.Id == id);
            if (order != null)
            {
                order.Status = -1;
                db.Orders.Update(order);
                db.SaveChanges();
            }
            else {
                Danger(string.Format("<b>Lỗi không tồn tại đơn hàng</b> "), true);
            }
            ViewBag.Total = order.Amount;
            //return Redirect(Url.RouteUrl(new {controller="Order",action="Index",area="Admin" }));
            return RedirectToAction("Index","Order");
        }

        [Area("Admin")]
        public  ContentResult SetCodeOrder()
        {
            var order = db.Orders.Include(u => u.Customer).Include(u => u.OrderDetails).ThenInclude(a => a.Product).ToList();
            // ViewBag.Total = order.Amount;
            foreach (var model in order) {
                if (model.Id!=8) {
                    model.CodeOrder = "DH" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "" + model.Id.ToString("D10");
                }
                db.Orders.Update(model);
            }
            db.SaveChanges();
            return Content("Update success...");
        }
        [HttpPost]
        [Area("Admin")]
        public IActionResult SetStatusOrder(IFormCollection form) {
            var order = db.Orders.Where(u=>u.Id == int.Parse(form["idorder"])).SingleOrDefault();
            var status_old = order.Status;
            order.Status = int.Parse(form["status"]);
            db.SaveChanges();
            if (status_old == 2 && (status_old != order.Status)) {
                ReduceQuantity(int.Parse(form["idorder"]));
            }
            if (order.Status == 2 ) {
                IncreaseQuantity(int.Parse(form["idorder"]));
            }
            return RedirectToAction("Index", "Order");
        }
        public bool ReduceQuantity(int idorder)
        {
            try
            {
                var order = db.Orders.Where(u => u.Id == idorder).Include(u => u.OrderDetails).ThenInclude(a => a.Product).SingleOrDefault();
                if (order != null)
                {
                    foreach (var d in order.OrderDetails)
                    {
                        var p = d.Product;
                        if (p != null)
                        {
                            p.Quantity = p.Quantity - d.Quantity;
                            db.Products.Update(p);
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool IncreaseQuantity(int idorder)
        {
            try
            {
                var order = db.Orders.Where(u => u.Id == idorder).Include(u => u.OrderDetails).ThenInclude(a => a.Product).SingleOrDefault();
                if (order != null)
                {
                    foreach (var d in order.OrderDetails)
                    {
                        var p = d.Product;
                        if (p != null)
                        {
                            p.Quantity = p.Quantity + d.Quantity;
                            db.Products.Update(p);
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult UpdateOrder(IFormCollection _form) {
            var order = db.Orders.Include(x=>x.OrderDetails).SingleOrDefault(x => x.Id == int.Parse(_form["orderid"]));
            if (order != null) {
                try {
                    var list_orderdt = new List<OrderDetail>();
                    var p = _form["Product[]"];
                    foreach (var id in p)
                    {
                        var orderdetail = new OrderDetail();
                        var quantity = int.Parse(_form["Product[" + id + "][quantity]"].ToString());
                        var price = double.Parse(_form["Product[" + id + "][price]"].ToString());
                        orderdetail.Quantity = quantity;
                        orderdetail.ProductId = int.Parse(id);
                        orderdetail.Discount = float.Parse(_form["Product[" + id + "][discount]"].ToString()) / 100;
                        orderdetail.UnitPrice = price;
                        list_orderdt.Add(orderdetail);
                    }
                    var amount = list_orderdt.Sum(x => x.UnitPrice * x.Quantity * (1 - x.Discount));
                    order.OrderDetails.ToList().RemoveAll(x => x.OrderId == order.Id);
                    //list_order_o.RemoveAll();
                    order.OrderDetails = list_orderdt;
                    order.Amount = amount;
                    db.Orders.Update(order);
                    db.SaveChanges();
                    Success(string.Format("<b>Thay đổi đơn hàng thành công..</b> "), true);
                    return RedirectToAction("Detail", "Order", new { id = order.Id });
                } catch (Exception e) {
                    Danger(string.Format("<b>Lỗi "+e.Message+" "+e.InnerException.Message+"</b> "), true);
                    return RedirectToAction("Detail", "Order", new { id = order.Id });
                }
                
            }
            Danger(string.Format("<b>Đơn hàng không tồn tại..</b> "), true);
            return RedirectToAction("Index", "Order");
        }

    }
}