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
    public class ProgramadoresController : Controller
    {
        private readonly ELearningDbContext _context;

        public ProgramadoresController(ELearningDbContext context)
        {
            _context = context;
        }

        // GET: Programadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Programadores.ToListAsync());
        }

        // GET: Programadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Programadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programador == null)
            {
                return NotFound();
            }

            return View(programador);
        }

        // GET: Programadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Programadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido")] Programador programador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programador);
        }

        // GET: Programadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Programadores.FindAsync(id);
            if (programador == null)
            {
                return NotFound();
            }
            return View(programador);
        }

        // POST: Programadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido")] Programador programador)
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

        // GET: Programadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Programadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programador == null)
            {
                return NotFound();
            }

            return View(programador);
        }

        // POST: Programadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programador = await _context.Programadores.FindAsync(id);
            _context.Programadores.Remove(programador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramadorExists(int id)
        {
            return _context.Programadores.Any(e => e.Id == id);
        }
    }
}
