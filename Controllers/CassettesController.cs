using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BowllyForever.Models;

namespace BowllyForever.Controllers
{
    public class CassettesController : Controller
    {
        private readonly EF_BowllyContext _context;

        public CassettesController(EF_BowllyContext context)
        {
            _context = context;
        }

        // GET: Cassettes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cassette.ToListAsync());
        }

        // GET: Cassettes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cassette = await _context.Cassette
                .SingleOrDefaultAsync(m => m.CassetteId == id);
            if (cassette == null)
            {
                return NotFound();
            }

            return View(cassette);
        }

        // GET: Cassettes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cassettes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CassetteId,Artist,Title,RecordCo,Label,CatNo,Location,Released,Front,Back")] Cassette cassette)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cassette);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cassette);
        }

        // GET: Cassettes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cassette = await _context.Cassette.SingleOrDefaultAsync(m => m.CassetteId == id);
            if (cassette == null)
            {
                return NotFound();
            }
            return View(cassette);
        }

        // POST: Cassettes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CassetteId,Artist,Title,RecordCo,Label,CatNo,Location,Released,Front,Back")] Cassette cassette)
        {
            if (id != cassette.CassetteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cassette);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CassetteExists(cassette.CassetteId))
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
            return View(cassette);
        }

        // GET: Cassettes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cassette = await _context.Cassette
                .SingleOrDefaultAsync(m => m.CassetteId == id);
            if (cassette == null)
            {
                return NotFound();
            }

            return View(cassette);
        }

        // POST: Cassettes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cassette = await _context.Cassette.SingleOrDefaultAsync(m => m.CassetteId == id);
            _context.Cassette.Remove(cassette);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CassetteExists(int id)
        {
            return _context.Cassette.Any(e => e.CassetteId == id);
        }
    }
}
