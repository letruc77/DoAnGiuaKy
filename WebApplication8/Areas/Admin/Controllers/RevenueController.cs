using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using WebApplication8.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class RevenueController : AdminController
    {
        private readonly WebShopContext db;
        public RevenueController(WebShopContext context) {
            db = context;
        }

        [Area("Admin")]
        public IActionResult byProduct(DateTime? Min = null, DateTime? Max = null)
        {
            if (Min == null)
            {
                Min = DateTime.MinValue;
            }
            if (Max == null)
            {
                Max = DateTime.MaxValue;
            }


            var model = db.OrderDetails
                .Include(u => u.Product).Where(x=>x.Id > 0);
               // .Where(d => d.Order.OrderDate >= Min && d.Order.OrderDate <= Max)
              // 
                
            if (!string.IsNullOrEmpty(Request.Query["status"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.Status == int.Parse(Request.Query["status"].ToString()));
            }
            if (!string.IsNullOrEmpty(Request.Query["datestart"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["datestart"].ToString()) >= 0);
                ViewBag.datestart = Request.Query["datestart"];
            }
            if (!string.IsNullOrEmpty(Request.Query["dateend"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["dateend"].ToString()) < 0);
                ViewBag.dateend = Request.Query["dateend"];
            }

           var model_rs = model.GroupBy(d => d.Product.Name).Select(g => new ReportInfo
            {
                Group = g.Key,
                Sum = g.Sum(d => d.UnitPrice * d.Quantity * (1 - d.Discount)),
                Count = g.Sum(d => d.Quantity),
                Min = g.Min(d => d.UnitPrice),
                Max = g.Max(d => d.UnitPrice),
                Avg = g.Average(d => d.UnitPrice)
            });


            ViewBag.FlagSearch = true;
           
            return View("Index", model_rs);
        }

        [Area("Admin")]
        public IActionResult byCategory(DateTime? Min = null, DateTime? Max = null)
        {
            if (Min == null)
            {
                Min = DateTime.MinValue;
            }
            if (Max == null)
            {
                Max = DateTime.MaxValue;
            }
            var model = db.OrderDetails.Where(x=>x.Id > 0);
            if (!string.IsNullOrEmpty(Request.Query["status"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.Status == int.Parse(Request.Query["status"].ToString()));
            }
            if (!string.IsNullOrEmpty(Request.Query["datestart"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["datestart"].ToString()) >= 0);
                ViewBag.datestart = Request.Query["datestart"];
            }
            if (!string.IsNullOrEmpty(Request.Query["dateend"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["dateend"].ToString()) < 0);
                ViewBag.dateend = Request.Query["dateend"];
            }
            var model_rs = model.GroupBy(d => d.Product.Category)
                .Select(g => new ReportInfo
                {
                    Group = g.Key.Name,
                    Sum = g.Sum(x=>x.Order.Amount),
                    Count = g.Count(),
                    Min = g.Min(x => x.Order.Amount),
                    Max = g.Max(x => x.Order.Amount),
                    Avg = g.Average(x => x.Order.Amount)
                });




            ViewBag.FlagSearch = true;
            return View("Index", model_rs);
        }

        [Area("Admin")]
        public IActionResult bySupplier(DateTime? Min = null, DateTime? Max = null)
        {
            if (Min == null)
            {
                Min = DateTime.MinValue;
            }
            if (Max == null)
            {
                Max = DateTime.MaxValue;
            }
            var model = db.OrderDetails.Include(x => x.Product).Where(x => x.Id > 0);
            if (!string.IsNullOrEmpty(Request.Query["status"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.Status == int.Parse(Request.Query["status"].ToString()));
            }
            if (!string.IsNullOrEmpty(Request.Query["datestart"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["datestart"].ToString()) >= 0);
                ViewBag.datestart = Request.Query["datestart"];
            }
            if (!string.IsNullOrEmpty(Request.Query["dateend"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["dateend"].ToString()) < 0);
                ViewBag.dateend = Request.Query["dateend"];
            }

            var model_rs = model.GroupBy(d => d.Product.Supplier)
                .Select(g => new ReportInfo
                {
                    Group = g.Key.Name,
                    Sum = g.Sum(x => x.Order.Amount),
                    Count = g.Count(),
                    Min = g.Min(x => x.Order.Amount),
                    Max = g.Max(x => x.Order.Amount),
                    Avg = g.Average(x => x.Order.Amount)
                });
            ViewBag.FlagSearch = true;
            return View("Index", model_rs);
        }

        [Area("Admin")]
        public IActionResult byCustomer(DateTime? Min = null, DateTime? Max = null)
        {
            if (Min == null)
            {
                Min = DateTime.MinValue;
            }
            if (Max == null)
            {
                Max = DateTime.MaxValue;
            }
            var model = db.OrderDetails.Where(x=>x.Id > 0);
            if (!string.IsNullOrEmpty(Request.Query["status"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.Status == int.Parse(Request.Query["status"].ToString()));
            }
            if (!string.IsNullOrEmpty(Request.Query["datestart"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["datestart"].ToString()) >= 0);
                ViewBag.datestart = Request.Query["datestart"];
            }
            if (!string.IsNullOrEmpty(Request.Query["dateend"].ToString()))
            {
                // var a = "abc";
                model = model.Where(x => x.Order.OrderDate.ToString("yyyy/MM/dd").CompareTo(Request.Query["dateend"].ToString()) < 0);
                ViewBag.dateend = Request.Query["dateend"];
            }

            var model_rs = model.GroupBy(d => d.Order.Customer.Fullname)
             .Select(g => new ReportInfo
             {
                 Group = g.Key,
                 Sum = g.Sum(d => d.Order.Amount),
                 Count = g.Count(),
                 Min = g.Min(d => d.Order.Amount),
                 Max = g.Max(d => d.Order.Amount),
                 Avg = g.Average(d => d.Order.Amount)
             });
            
            ViewBag.FlagSearch = true;
            return View("Index", model_rs);
        }

        [Area("Admin")]
        public IActionResult byYear()
        {
            var model = db.OrderDetails
                .GroupBy(d => d.Order.OrderDate.Year)
                .Select(g => new ReportInfo
                {
                    //iGroup = g.Key,
                    Group = "Year "+g.Key,
                    Sum = g.Sum(d=>d.Order.Amount),
                    Count = g.Count(),
                    Min = g.Min(d => d.Order.Amount),
                    Max = g.Max(d => d.Order.Amount),
                    Avg = g.Average(d => d.Order.Amount)
                })
                .OrderBy(i => i.Group);
            return View("Index", model);
        }

        [Area("Admin")]
        public IActionResult byMonth()
        {
            var model = db.OrderDetails
                .Where(d => d.Order.OrderDate.Month == DateTime.Now.Month)
                .GroupBy(d => d.Order.OrderDate.Month)
                .Select(g => new ReportInfo
                {
                    ///iGroup = g.Key,
                    Group="Month "+g.Key,
                    Sum = g.Sum(d => d.Order.Amount),
                    Count = g.Count(),
                    Min = g.Min(d => d.Order.Amount),
                    Max = g.Max(d => d.Order.Amount),
                    Avg = g.Average(d => d.Order.Amount)
                })
                .OrderBy(i => i.Group);
            return View("Index", model);
        }

        [Area("Admin")]
        public IActionResult byQuarter()
        {
            var model = db.OrderDetails
                .GroupBy(d => (d.Order.OrderDate.Month - 1) / 3 + 1)
                .Select(g => new ReportInfo
                {
                    //iGroup = g.Key,
                    Group= "Quarter " + g.Key,
                    Sum = g.Sum(d => d.Order.Amount),
                    Count = g.Count(),
                    Min = g.Min(d => d.Order.Amount),
                    Max = g.Max(d => d.Order.Amount),
                    Avg = g.Average(d => d.Order.Amount)
                })
                .OrderBy(i => i.Group);
            return View("Index", model);
        }
    }
}