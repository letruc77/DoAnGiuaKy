using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models.WebShop;
using WebApplication8.Data;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class CategoryController : AdminController
    {
        private readonly WebShopContext db;
        public CategoryController(WebShopContext context) {
            db = context;

        }

        [Area("Admin")]
        public ActionResult Index()
        {
            var model = new Category();
            ViewBag.Category = db.Categories.ToList();
            ViewBag.LastId = getLastProduct();
            return View(model);
        }
        public int getLastProduct()
        {

            var LastId = 0;
            try
            {
                LastId = db.Categories
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
        [HttpPost]
        public ActionResult Insert(Category model)
        {
            try
            {
                ViewBag.Category = db.Categories.ToList();
                if (ModelState.IsValid)
                {
                    db.Categories.Add(model);
                    db.SaveChanges();
                  
                    Success(string.Format("<b>{0}</b> thêm thành công.", model.Name), true);

                }
                Danger(string.Format("<b>{0}</b> .", "Please type info valid"), true);


            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "L?i: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> thêm l?i.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }
            ViewBag.LastId = getLastProduct();
            return View("Index", model);
        }



        //-----------------------------------//
        [Area("Admin")]
        public ActionResult Edit(int Id)
        {
            var model = db.Categories.Single(p => p.Id == Id);
            ViewBag.Category = db.Categories.ToList();
            ViewBag.LastId = getLastProduct();
            return View("Index", model);
        }
        //------------------------------//



        [Area("Admin")]
        [HttpPost]
        public ActionResult Update(Category model)
        {
            try
            {
                var newmodel = db.Categories.Single(p => p.Id == model.Id);
                newmodel.Name = model.Name;
                newmodel.NameVN = model.NameVN;
                newmodel.Image = model.Image;
                newmodel.Icon = model.Icon;
                db.SaveChanges();
                ViewBag.Category = db.Categories.ToList();
                Success(string.Format("<b>{0}</b> c?p nh?t thành công.", model.Name), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "L?i: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Thêm l?i.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }
            return View("Index", model);
        }

        [Area("Admin")]
        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.Categories.Single(p => p.Id == Id);
                db.Categories.Remove(model);
                db.SaveChanges();
                Success(string.Format("<b>{0}</b> xoá thành công.", model.Name), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "L?i: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Thêm thành công.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [Area("Admin")]
        public ActionResult DeleteSelected(int[] ids)
        {
            try
            {

                var items = "";
                if (ids.ToString() == null)
                {

                    ModelState.AddModelError("", "Ch?a ch?n dòng ?? xoá !");

                }


                foreach (var item in ids)
                {
                    var sp = db.Categories.Single(p => p.Id == item);
                    items += sp.Name + ", ";
                    db.Categories.Remove(sp);
                    db.SaveChanges();
                }
                Success(string.Format("<b>{0}</b> xoá thành công.", items), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "L?i: " + e.InnerException);
                Danger(string.Format("<b>{0}</b> Thêm l?i.", e.Message + e.InnerException), true);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}