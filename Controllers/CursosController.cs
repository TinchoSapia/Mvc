using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using TpMVC.Data;
using TpMVC.Models;

namespace TpMVC.Controllers
{
    public class CursosController : Controller
    {
        private readonly ELearningDbContext _context;
        

        public CursosController(ELearningDbContext context)
        {
            _context = context;
        }

        // GET: Cursos
        public async Task<IActionResult> Index()
        {
            
            var eLearningDbContext = _context.Cursos
                .Include(c => c.Lenguaje)
                .Include(c => c.Nivel)
                .Include(c => c.Video)
                .Include(c => c.Profesor);
            return View(await eLearningDbContext.ToListAsync());
        }
        [Authorize(Roles = "cliente")]
        public async Task<IActionResult> MisCursos()
        {
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(usr => usr.Email == User.Identity.Name.ToLower());
            var misCursos = _context.CursoUsuarios
                .Where(x => x.UsuarioId == usuario.Id)
                .Include(c => c.Curso)
                .Include(c => c.Usuario);
            return View(await misCursos.ToListAsync());
        }
        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Lenguaje)
                .Include(c => c.Nivel)
                .Include(c => c.Video)
                .Include(c => c.Profesor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }
        
       
        public IActionResult Create()
        {
            ViewData["LenguajeId"] = new SelectList(_context.Lenguajes, "Id", "Nombre");
            ViewData["NivelId"] = new SelectList(_context.Niveles, "Id", "Nombre");
            ViewData["ProfesorId"] = new SelectList(_context.Profesores, "Id", "NombreApellido");
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "ServidorStreaming");
            return View(); 
        }

        // POST: Cursos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,ProfesorId,AnioPublicado,LenguajeId,NivelId,VideoId,Ruta")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LenguajeId"] = new SelectList(_context.Lenguajes, "Id", "Nombre", curso.LenguajeId);
            ViewData["NivelId"] = new SelectList(_context.Niveles, "Id", "Nombre", curso.NivelId);
            ViewData["ProfesorId"] = new SelectList(_context.Profesores, "Id", "NombreApellido", curso.ProfesorId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "ServidorStreaming", curso.VideoId);
            return View(curso);
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            ViewData["LenguajeId"] = new SelectList(_context.Lenguajes, "Id", "Nombre", curso.LenguajeId);
            ViewData["NivelId"] = new SelectList(_context.Niveles, "Id", "Nombre", curso.NivelId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "ServidorStreaming", curso.VideoId);
            ViewData["ProfesorId"] = new SelectList(_context.Profesores, "Id", "NombreApellido", curso.ProfesorId);
            ViewData["CantSubscriptos"] = curso.CantSubscriptos;
            return View(curso);
        }

        // POST: Cursos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,ProfesorId,AnioPublicado,LenguajeId,NivelId,VideoId,Ruta,CantSubscriptos")] Curso curso)
        {
            if (id != curso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoExists(curso.Id))
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
            ViewData["LenguajeId"] = new SelectList(_context.Lenguajes, "Id", "Nombre", curso.LenguajeId);
            ViewData["NivelId"] = new SelectList(_context.Niveles, "Id", "Nombre", curso.NivelId);
            ViewData["VideoId"] = new SelectList(_context.Videos, "Id", "ServidorStreaming", curso.VideoId);
            return View(curso);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Lenguaje)
                .Include(c => c.Nivel)
                .Include(c => c.Video)
                .Include(c => c.Profesor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
        private bool CursoExists(int id)
        {
            return _context.Cursos.Any(e => e.Id == id);
        }
    }
}
