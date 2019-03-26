using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models.WebShop;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class MessageSystemsController : Controller
    {
        private readonly WebShopContext _context;

        public MessageSystemsController(WebShopContext context)
        {
            _context = context;    
        }

        // GET: MessageSystems
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MessageSystems.ToListAsync());
        }

        // GET: MessageSystems/Details/5
        [Area("Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messageSystem = await _context.MessageSystems.SingleOrDefaultAsync(m => m.Id == id);
            if (messageSystem == null)
            {
                return NotFound();
            }

            return View(messageSystem);
        }

        // GET: MessageSystems/Create
        [Area("Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: MessageSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,CreateDate,Status,TypeMessage")] MessageSystem messageSystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(messageSystem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(messageSystem);
        }

        // GET: MessageSystems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messageSystem = await _context.MessageSystems.SingleOrDefaultAsync(m => m.Id == id);
            if (messageSystem == null)
            {
                return NotFound();
            }
            return View(messageSystem);
        }

        // POST: MessageSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,CreateDate,Status,TypeMessage")] MessageSystem messageSystem)
        {
            if (id != messageSystem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(messageSystem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessageSystemExists(messageSystem.Id))
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
            return View(messageSystem);
        }

        // GET: MessageSystems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messageSystem = await _context.MessageSystems.SingleOrDefaultAsync(m => m.Id == id);
            if (messageSystem == null)
            {
                return NotFound();
            }

            return View(messageSystem);
        }

        // POST: MessageSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var messageSystem = await _context.MessageSystems.SingleOrDefaultAsync(m => m.Id == id);
            _context.MessageSystems.Remove(messageSystem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MessageSystemExists(int id)
        {
            return _context.MessageSystems.Any(e => e.Id == id);
        }
    }
}
