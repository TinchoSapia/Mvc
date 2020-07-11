﻿using System;
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
    [Authorize(Roles ="administrador")]
    public class LenguajesController : Controller
    {
        private readonly ELearningDbContext _context;

        public LenguajesController(ELearningDbContext context)
        {
            _context = context;
        }

        // GET: Lenguajes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lenguajes.ToListAsync());
        }

        // GET: Lenguajes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lenguaje = await _context.Lenguajes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lenguaje == null)
            {
                return NotFound();
            }

            return View(lenguaje);
        }

        // GET: Lenguajes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lenguajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Version")] Lenguaje lenguaje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lenguaje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lenguaje);
        }

        // GET: Lenguajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lenguaje = await _context.Lenguajes.FindAsync(id);
            if (lenguaje == null)
            {
                return NotFound();
            }
            return View(lenguaje);
        }

        // POST: Lenguajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Version")] Lenguaje lenguaje)
        {
            if (id != lenguaje.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lenguaje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LenguajeExists(lenguaje.Id))
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
            return View(lenguaje);
        }

        // GET: Lenguajes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lenguaje = await _context.Lenguajes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lenguaje == null)
            {
                return NotFound();
            }

            return View(lenguaje);
        }

        // POST: Lenguajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lenguaje = await _context.Lenguajes.FindAsync(id);
            _context.Lenguajes.Remove(lenguaje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LenguajeExists(int id)
        {
            return _context.Lenguajes.Any(e => e.Id == id);
        }
    }
}
