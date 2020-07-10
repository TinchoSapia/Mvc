using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpMVC.Data;
using TpMVC.Models;

namespace TpMVC.Controllers
{
    [Authorize]
    public class ProfesoresController : Controller
    {
        private readonly ELearningDbContext _context;

        public ProfesoresController(ELearningDbContext context)
        {
            _context = context;
        }

        // GET: Profesores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Profesores.ToListAsync());
        }

        // GET: Profesores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Profesores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programador == null)
            {
                return NotFound();
            }

            return View(programador);
        }

        // GET: Profesores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido")] Profesor programador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programador);
        }

        // GET: Profesores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Profesores.FindAsync(id);
            if (programador == null)
            {
                return NotFound();
            }
            return View(programador);
        }

        // POST: Profesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido")] Profesor programador)
        {
            if (id != programador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramadorExists(programador.Id))
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
            return View(programador);
        }

        // GET: Profesores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Profesores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programador == null)
            {
                return NotFound();
            }

            return View(programador);
        }

        // POST: Profesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programador = await _context.Profesores.FindAsync(id);
            _context.Profesores.Remove(programador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramadorExists(int id)
        {
            return _context.Profesores.Any(e => e.Id == id);
        }
    }
}
