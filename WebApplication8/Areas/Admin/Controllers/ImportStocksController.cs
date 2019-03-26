using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models.WebShop;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class ImportStocksController : AdminController
    {
        private readonly WebShopContext _context;

        public ImportStocksController(WebShopContext context)
        {
            _context = context;    
        }

        [Area("Admin")]
        // GET: ImportStocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ImportStocks.ToListAsync());
        }
        [Area("Admin")]
        // GET: ImportStocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importStock = await _context.ImportStocks.SingleOrDefaultAsync(m => m.ID == id);
            if (importStock == null)
            {
                return NotFound();
            }

            return View(importStock);
        }

        [Area("Admin")]
        // GET: ImportStocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImportStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Area("Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ImportStock importStock,IFormCollection form_)
        {
            if (ModelState.IsValid)
            {
                var p = form_["Product[]"];
                var list_p = new List<object>();
                foreach (var id in p) {
                    var p_ = _context.Products.Where(u => u.Id == int.Parse(id.ToString())).SingleOrDefault();
                    if (p_ != null) {
                        var quantity = int.Parse(form_["Product[" + id + "][quantity]"].ToString());
                        p_.Quantity += quantity;
                        var p_o = new { id = id, quantity = quantity };
                        list_p.Add(p_o);
                        _context.Update(p_);
                    }
                }
                var detail_import = JsonConvert.SerializeObject(list_p);
                importStock.DetailImport = detail_import;
                importStock.Total = double.Parse(form_["total"].ToString());
                importStock.Updated = DateTime.Now;
                importStock.CreateDate = DateTime.Now;
                importStock.UserInit = User.Identity.Name;

                _context.Add(importStock);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(importStock);
        }

        [Area("Admin")]
        // GET: ImportStocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importStock = await _context.ImportStocks.SingleOrDefaultAsync(m => m.ID == id);
            if (importStock == null)
            {
                return NotFound();
            }
            return View(importStock);
        }

        // POST: ImportStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Area("Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CreateDate,DetailImport,Discount,IdStock,Lack,Notes,Payed,PaymentMt,Status,Total,Updated,UserInit,UserUpd")] ImportStock importStock)
        {
            if (id != importStock.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importStock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImportStockExists(importStock.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(importStock);
        }

        [Area("Admin")]
        // GET: ImportStocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importStock = await _context.ImportStocks.SingleOrDefaultAsync(m => m.ID == id);
            if (importStock == null)
            {
                return NotFound();
            }

            return View(importStock);
        }

        [Area("Admin")]
        // POST: ImportStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var importStock = await _context.ImportStocks.SingleOrDefaultAsync(m => m.ID == id);
            _context.ImportStocks.Remove(importStock);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Area("Admin")]
        private bool ImportStockExists(int id)
        {
            return _context.ImportStocks.Any(e => e.ID == id);
        }

        [Area("Admin")]
        public ActionResult DeleteSelected(int[] ids)
        {
            try
            {
                var items = "";
                if (ids == null)
                {

                    ModelState.AddModelError("", "Ch?n item c?n xoá !");

                }
                foreach (var item in ids)
                {
                    var imp = _context.ImportStocks.Single(p => p.ID == item);
                    items += imp.ID + ", ";
                    _context.ImportStocks.Remove(imp);
                    _context.SaveChanges();

                }
                Success(string.Format("<b>{0}</b> xoá thành công.", items), true);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException.Message);
                Danger(string.Format("<b>{0}</b> Xoá l?i.", e.Message + e.InnerException), true);
            }
            return RedirectToAction("Index");
        }
    }
}
