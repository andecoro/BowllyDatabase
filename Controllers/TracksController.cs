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
    public class TracksController : Controller
    {
        private readonly EF_BowllyContext _context;

        public TracksController(EF_BowllyContext context)
        {
            _context = context;
        }

        // GET: Tracks

        public async Task<IActionResult> Index(
           string sortOrder,
           string currentFilter,
           string searchString,
           int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var Tracks = from s in _context.Track
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Tracks = Tracks.Where(s => s.Title.Contains(searchString)
                                       || s.Artist.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    Tracks = Tracks.OrderByDescending(s => s.Title);
                    break;
                case "Date":
                    Tracks = Tracks.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    Tracks = Tracks.OrderByDescending(s => s.Date);
                    break;
                default:
                    Tracks = Tracks.OrderBy(s => s.Date);
                    break;
            }

            int pageSize = 50;
            return View(await PaginatedList<Track>.CreateAsync(Tracks.AsNoTracking(), page ?? 1, pageSize));
        }



        // GET: Tracks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Track
                .SingleOrDefaultAsync(m => m.TrackId == id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        // GET: Tracks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tracks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrackId,Title,Artist,Label,CatNo,Matrix,Date,Location,Comments,Words,Music,Youtube,Image,Mp3")] Track track)
        {
            if (ModelState.IsValid)
            {
                _context.Add(track);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(track);
        }

        // GET: Tracks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Track.SingleOrDefaultAsync(m => m.TrackId == id);
            if (track == null)
            {
                return NotFound();
            }
            return View(track);
        }

        // POST: Tracks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrackId,Title,Artist,Label,CatNo,Matrix,Date,Location,Comments,Words,Music,Youtube,Image,Mp3")] Track track)
        {
            if (id != track.TrackId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(track);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrackExists(track.TrackId))
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
            return View(track);
        }

        // GET: Tracks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Track
                .SingleOrDefaultAsync(m => m.TrackId == id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        // POST: Tracks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var track = await _context.Track.SingleOrDefaultAsync(m => m.TrackId == id);
            _context.Track.Remove(track);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrackExists(int id)
        {
            return _context.Track.Any(e => e.TrackId == id);
        }
    }
}
