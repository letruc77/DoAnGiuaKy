using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models.WebShop;
using WebApplication8.Data;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class SupplierController : AdminController
    {
        private readonly WebShopContext db;
        public SupplierController(WebShopContext context)
        {
            db = context;

        }

        [Area("Admin")]
        public ActionResult Index()
        {
            var model = new Supplier();

            ViewBag.Suppliers = db.Suppliers.ToList();
            //ViewBag.Customers = db.Customers.ToList();
            //View
            return View(model);
        }

        [Area("Admin")]
        [HttpPost]
        public ActionResult Insert(Supplier model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Suppliers.Add(model);
                    db.SaveChanges();
                    ViewBag.Suppliers = db.Suppliers.ToList();
                    Success(string.Format("<b>{0}</b> thành công.", model.Name), true);
                }
                else {
                    Danger(string.Format("<b>{0}</b>.", "Please type input valid"), true);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "error: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Lỗi.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");

            }
            // return View("Index");
            ViewBag.Suppliers = db.Suppliers.ToList();
            return View("Index", model);
        }


        //--------------------------//
        [Area("Admin")]
        public ActionResult Edit([Bind("Id")]string Id)
        {
            // var model = db.Suppliers.Find(Id);
            var model = db.Suppliers.Single(p => p.Id == Id);
            ViewBag.Suppliers = db.Suppliers.ToList();
            return View("Index", model);
        }


        [Area("Admin")]
        [HttpPost]
        public ActionResult Update(Supplier model)
        {
            try
            {
                if (ModelState.IsValid) {
                    var newModel = db.Suppliers.Single(p => p.Id == model.Id);
                    newModel.Id = model.Id;
                    newModel.Name = model.Name;
                    newModel.Email = model.Email;
                    newModel.Phone = model.Phone;
                    newModel.Logo = model.Logo;
                    db.SaveChanges();
                    ViewBag.Suppliers = db.Suppliers.ToList();
                    Success(string.Format("<b>{0}</b> cập nhật thành công.", model.Name), true);
                    return RedirectToAction("Index");
                }
                return View("Index", model);


            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "error: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Lỗi.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }
           
          
        }


        [Area("Admin")]
        public ActionResult Delete(String Id)
        {
            try
            {
                var model = db.Suppliers.Single(p => p.Id == Id);
                db.Suppliers.Remove(model);
                db.SaveChanges();
                Success(string.Format("<b>{0}</b> thành công.", model.Name), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "error: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Lỗi.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [Area("Admin")]
        public ActionResult DeleteSelected(string[] ids)
        {
            try
            {
                if (ids == null)
                {
                    ModelState.AddModelError("", "Chọn trước khi xoá... !");
                }
                foreach (var item in ids)
                {
                    var sp = db.Suppliers.Single(p => p.Id == item);
                    db.Suppliers.Remove(sp);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "error: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Lỗi.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}