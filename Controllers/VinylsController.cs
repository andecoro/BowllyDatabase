﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BowllyForever.Models;

namespace BowllyForever.Controllers
{
    public class VinylsController : Controller
    {
        private readonly EF_BowllyContext _context;

        public VinylsController(EF_BowllyContext context)
        {
            _context = context;
        }

        // GET: Vinyls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vinyl.ToListAsync());
        }

        // GET: Vinyls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinyl = await _context.Vinyl
                .SingleOrDefaultAsync(m => m.VinylId == id);
            if (vinyl == null)
            {
                return NotFound();
            }

            return View(vinyl);
        }

        // GET: Vinyls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vinyls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VinylId,Artist,Title,RecordCo,Label,CatNo,Location,Year,Size,Front,Bowllyonvinyl")] Vinyl vinyl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vinyl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vinyl);
        }

        // GET: Vinyls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinyl = await _context.Vinyl.SingleOrDefaultAsync(m => m.VinylId == id);
            if (vinyl == null)
            {
                return NotFound();
            }
            return View(vinyl);
        }

        // POST: Vinyls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VinylId,Artist,Title,RecordCo,Label,CatNo,Location,Year,Size,Front,Bowllyonvinyl")] Vinyl vinyl)
        {
            if (id != vinyl.VinylId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vinyl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VinylExists(vinyl.VinylId))
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
            return View(vinyl);
        }

        // GET: Vinyls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinyl = await _context.Vinyl
                .SingleOrDefaultAsync(m => m.VinylId == id);
            if (vinyl == null)
            {
                return NotFound();
            }

            return View(vinyl);
        }

        // POST: Vinyls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vinyl = await _context.Vinyl.SingleOrDefaultAsync(m => m.VinylId == id);
            _context.Vinyl.Remove(vinyl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VinylExists(int id)
        {
            return _context.Vinyl.Any(e => e.VinylId == id);
        }
    }
}
