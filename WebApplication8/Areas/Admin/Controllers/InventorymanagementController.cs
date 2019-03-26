using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using WebApplication8.Areas.Admin.Models;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class InventorymanagementController : AdminController
    {
        WebShopContext db ;

        public InventorymanagementController(WebShopContext _db) {
            db = _db;
        }

        [Area("Admin")]
        public ActionResult ByCategory()
        {
            var model = db.Products
                .GroupBy(p => p.Category)
                .Select(g => new ReportInfo
                {
                    Group = g.Key.NameVN,
                    Count = g.Sum(p => p.Quantity),
                    Sum = g.Sum(p => p.PriceP * p.Quantity),
                    Min = g.Min(p => p.PriceP),
                    Max = g.Max(p => p.PriceP),
                    Avg = g.Average(p => p.PriceP)
                });
            return View("Index", model);
        }

        [Area("Admin")]
        public ActionResult BySupplier()
        {
            var model = db.Products
                .GroupBy(p => p.Supplier)
                .Select(g => new ReportInfo
                {
                    Group = g.Key.Name,
                    Count = g.Sum(p => p.Quantity),
                    Sum = g.Sum(p => p.PriceP * p.Quantity),
                    Min = g.Min(p => p.PriceP),
                    Max = g.Max(p => p.PriceP),
                    Avg = g.Average(p => p.PriceP)
                });
            return View("Index", model);
        }
    }
}