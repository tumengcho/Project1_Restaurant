using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using restaurantApi.Data;
using restaurantApi.Models;
using restaurantApi.URL;

namespace restaurantApi.Areas.admin.controllers
{
    [Area("admin")]
    public class platsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public platsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: admin/plats
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string randomUrl = UrlGenerator.GenerateRandomUrl(10);
            Console.WriteLine("URL aléatoire générée : " + randomUrl);
            return _context.plat != null ? 
                          View(await _context.plat.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.plat'  is null.");
        }

        // GET: admin/plats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.plat == null)
            {
                return NotFound();
            }

            var plat = await _context.plat
                .FirstOrDefaultAsync(m => m.id == id);
            if (plat == null)
            {
                return NotFound();
            }

            return View(plat);
        }

        // GET: admin/plats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/plats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,prix,images")] plat plat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plat);
        }

        // GET: admin/plats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.plat == null)
            {
                return NotFound();
            }

            var plat = await _context.plat.FindAsync(id);
            if (plat == null)
            {
                return NotFound();
            }
            return View(plat);
        }

        // POST: admin/plats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,prix,images")] plat plat)
        {
            if (id != plat.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!platExists(plat.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(plat);
        }

        // GET: admin/plats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.plat == null)
            {
                return NotFound();
            }

            var plat = await _context.plat
                .FirstOrDefaultAsync(m => m.id == id);
            if (plat == null)
            {
                return NotFound();
            }

            return View(plat);
        }

        // POST: admin/plats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.plat == null)
            {
                return Problem("Entity set 'ApplicationDbContext.plat'  is null.");
            }
            var plat = await _context.plat.FindAsync(id);
            if (plat != null)
            {
                _context.plat.Remove(plat);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool platExists(int id)
        {
          return (_context.plat?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
