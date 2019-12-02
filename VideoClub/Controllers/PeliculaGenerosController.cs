using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoClub.DataBase;
using VideoClub.Models;

namespace VideoClub.Controllers
{
    public class PeliculaGenerosController : Controller
    {
        private readonly VideoClubDbContext _context;

        public PeliculaGenerosController(VideoClubDbContext context)
        {
            _context = context;
        }

        // GET: PeliculaGeneros
        public async Task<IActionResult> Index()
        {
            var videoClubDbContext = _context.PeliculasGeneros.Include(p => p.Genero).Include(p => p.Pelicula);
            return View(await videoClubDbContext.ToListAsync());
        }

        // GET: PeliculaGeneros/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros
                .Include(p => p.Genero)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }

            return View(peliculaGenero);
        }

        // GET: PeliculaGeneros/Create
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            return View();
        }

        // POST: PeliculaGeneros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PeliculaId,GeneroId")] PeliculaGenero peliculaGenero)
        {
            if (ModelState.IsValid)
            {
                peliculaGenero.Id = Guid.NewGuid();
                _context.Add(peliculaGenero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // GET: PeliculaGeneros/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros.FindAsync(id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // POST: PeliculaGeneros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PeliculaId,GeneroId")] PeliculaGenero peliculaGenero)
        {
            if (id != peliculaGenero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculaGenero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaGeneroExists(peliculaGenero.Id))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // GET: PeliculaGeneros/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros
                .Include(p => p.Genero)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }

            return View(peliculaGenero);
        }

        // POST: PeliculaGeneros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var peliculaGenero = await _context.PeliculasGeneros.FindAsync(id);
            _context.PeliculasGeneros.Remove(peliculaGenero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaGeneroExists(Guid id)
        {
            return _context.PeliculasGeneros.Any(e => e.Id == id);
        }
    }
}
