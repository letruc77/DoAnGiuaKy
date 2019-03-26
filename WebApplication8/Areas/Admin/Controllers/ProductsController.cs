using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models.WebShop;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class ProductsController : AdminController
    {
        private readonly WebShopContext _context;
        private IHostingEnvironment _environment;
        public ProductsController(WebShopContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        [Area("Admin")]
        // GET: Admin/Product
        public ActionResult Index()
        {

            var model = _context.Products.Include(u => u.Category).Include(u => u.Supplier).ToList();
            return View(model);
        }
        public int getLastProduct()
        {

            var LastId = 0;
            try
            {
                LastId = _context.Products
                .OrderByDescending(q => q.Id)
                .Select(q => q.Id)
                .First();
            }
            catch
            {

            }

            return LastId + 1;

        }

        [Area("Admin")]
        public ActionResult Insert()
        {
            ViewBag.CategoryId = new SelectList(_context.Categories, "Id", "Name");
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "Name");
            ViewData["LastId"] = getLastProduct();
            return View();
        }
        //[Bind(Exclude = "Id")]

        [Area("Admin")]
        [HttpPost]
        public async Task<ActionResult> Insert(Product model, IFormCollection data)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    //var f = Request.Files["uplImage"];
                    //if (f != null && f.ContentLength > 0)
                    //{
                    //    model.Image = model.Id
                    //     + f.FileName.Substring(f.FileName.LastIndexOf("."));
                    //    f.SaveAs(Server.MapPath("/Content/img/products/" + model.Image));

                    //}

                    //var filename_ = HttpContext.Request;
                    // var filename = "asdas.php";
                    // var tmp = filename.Substring(filename.LastIndexOf("/"));
                    // tmp = tmp.Replace("/", "");
                    // model.Image = tmp;
                    var uploads = Path.Combine(_environment.WebRootPath, "Content/img/products/images");

                    var fhinh = HttpContext.Request.Form.Files["uplImage"];
                    using (var fileStream = new FileStream(Path.Combine(uploads, fhinh.FileName), FileMode.Create))
                    {
                        await fhinh.CopyToAsync(fileStream);
                    }
                    var pathhinh = fhinh.FileName;
                    model.Image = pathhinh;

                    model.PriceP = Double.Parse(data["PriceP"].ToString().Replace(",", ""));
                    _context.Products.Add(model);
                    _context.SaveChanges();
                    Success(string.Format("<b>{0}</b> thêm thành công.", model.Name), true);
                    return RedirectToAction("Index");


                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                Danger(string.Format("<b>{0}</b> Thêm lỗi.", e.Message), false);

            }
            ViewBag.CategoryId = new SelectList(_context.Categories, "Id", "Name", model.CategoryId);
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "Name", model.SupplierId);
            ViewBag.LastId = getLastProduct();
            return View();
            //return RedirectToAction("Insert");
        }

        [Area("Admin")]
        public ActionResult Edit(int Id)
        {
            ViewBag.CategoryId = new SelectList(_context.Categories, "Id", "Name");
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "Name");
            var model = _context.Products.Include(u => u.Category).Include(u => u.Supplier).Single(p => p.Id == Id);

            return View(model);

        }

        [Area("Admin")]
        [HttpPost]
        public async Task<ActionResult> Update(Product model, IFormCollection data)
        {
            try
            {
                var newModel = _context.Products.Include(u => u.Category).Include(u => u.Supplier).Single(p => p.Id == model.Id);

                //  var filename = Request["Image"];
                //  var tmp = filename.Substring(filename.LastIndexOf("/"));
                //  tmp = tmp.Replace("/", "");
                //  model.Image = tmp;
                //  newModel.Image = model.Image.Substring(model.Image.LastIndexOf("/"));
                //   newModel.Image = newModel.Image.Replace("/","");
                /* if (model.Image.Contains("/"))
                 {
                     newModel.Image = model.Image.Substring(model.Image.LastIndexOf("/"));
                     newModel.Image = newModel.Image.Replace("/", "");

                 }
                 else
                 {
                     newModel.Image = model.Image;
                 }*/

                var uploads = Path.Combine(_environment.WebRootPath, "Content/img/products/images");

                var fhinh = HttpContext.Request.Form.Files["uplImage"];
                if (fhinh != null && fhinh.FileName != "")
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, fhinh.FileName), FileMode.Create))
                    {
                        await fhinh.CopyToAsync(fileStream);
                    }
                    var pathhinh = fhinh.FileName;
                    newModel.Image = pathhinh;
                }

                //  model.Image = pathhinh;
                newModel.PriceP = Double.Parse(data["PriceP"].ToString().Replace(",", ""));
                newModel.Id = model.Id;
                newModel.Name = model.Name;
                newModel.Latest = model.Latest;
                newModel.Special = model.Special;
                newModel.Special = model.Special;
                newModel.ProductDate = model.ProductDate;
                newModel.SupplierId = model.SupplierId;

                // newModel.UnitPrice = model.UnitPrice;
                newModel.Views = model.Views;
                newModel.Description = model.Description;
                newModel.Discount = model.Discount;
                _context.SaveChanges();

                Success(string.Format("<b>{0}</b> Update thành công.", model.Name), true);
                return RedirectToAction("Index", "Products");
            }
            catch (Exception e)
            {
                // ModelState.AddModelError("", e.InnerException);
                Danger(string.Format("<b>{0}</b> Update lỗi.", e.Message + e.InnerException), true);

            }
            ViewBag.CategoryId = new SelectList(_context.Categories, "Id", "Name", model.CategoryId);
            ViewBag.SupplierId = new SelectList(_context.Suppliers, "Id", "Name", model.SupplierId);
            return View("Edit", model);
            // return RedirectToAction("Index");
        }

        [Area("Admin")]
        public ActionResult Delete(int Id)
        {
            try
            {
                var model = _context.Products.Single(p => p.Id == Id);
                _context.Products.Remove(model);
                _context.SaveChanges();
                Success(string.Format("<b>{0}</b> Xoá thành công.", ""), true);
            }
            catch
            {
                Danger(string.Format("<b>{0}</b> Xoá lỗi.", ""), true);
            }

            return RedirectToAction("Index");
        }

        [Area("Admin")]
        public ActionResult Detail(int id)
        {
            var model = _context.Products.Include(u => u.Category).Include(u => u.Supplier).SingleOrDefault(u => u.Id == id);
            return View("Detail", model);
        }

        [Area("Admin")]
        public ActionResult DeleteSelected(int[] ids)
        {
            try
            {

                var items = "";
                if (ids == null)
                {

                    ModelState.AddModelError("", "Chọn item cần xoá !");

                }
                foreach (var item in ids)
                {
                    var sp = _context.Products.Include(u => u.Category).Include(u => u.Supplier).Single(p => p.Id == item);
                    items += sp.Name + ", ";
                    _context.Products.Remove(sp);
                    _context.SaveChanges();

                }
                Success(string.Format("<b>{0}</b> xoá thành công.", items), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException.Message);
                Danger(string.Format("<b>{0}</b> Xoá lỗi.", e.Message + e.InnerException), true);
            }
            return RedirectToAction("Index");
        }
        [Area("Admin")]
        public IActionResult SearchProducts(string query)
        {
            var list_product = _context.Products.Where(u => u.Name.Contains(query)).ToList();
            var list_p_r = new List<object>();
            foreach (var p in list_product)
            {
                var p_ = new { name = p.Name, id = p.Id, price = p.PriceP, discount = p.Discount };
                list_p_r.Add(p_);
            }
            return Json(list_p_r);
        }




    }
}
