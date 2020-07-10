using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpMVC.Data;

namespace TpMVC.Models
{  
    [Authorize]
    public class CursoUsuariosController : Controller
    {
        private readonly ELearningDbContext _context;

        public CursoUsuariosController(ELearningDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "cliente")]
        // GET: CursoUsuarios
        public async Task<IActionResult> MisCursos()
        {
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(usr => usr.Email == User.Identity.Name.ToLower());
            var misCursos = _context.CursoUsuarios
                .Where(x => x.UsuarioId == usuario.Id)
                .Include(c => c.Curso)
                .Include(c => c.Usuario)
                .Include(c => c.Curso.Nivel)
                .Include(c=>c.Curso.Lenguaje)
                .Include(c=> c.Curso.Video);
            return View(await misCursos.ToListAsync());
        }

        public async Task<IActionResult> Disponibles()
        {
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(usr => usr.Email == User.Identity.Name.ToLower());
            var eLearningDbContext = _context.Cursos
                .Include(c => c.Lenguaje)
                .Include(c => c.Nivel)
                .Include(c => c.Video)
                .Include(c => c.Profesor);

            ViewData["UsuarioId"] = usuario.Id;

            return View(await eLearningDbContext.ToListAsync());


        }

        // GET: CursoUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoUsuario = await _context.CursoUsuarios
                .Include(c => c.Curso)
                .Include(c => c.Usuario)
                .Include(c => c.Curso.Lenguaje)
                .Include(c => c.Curso.Nivel)
                .Include(c => c.Curso.Video)
                .Include(c => c.Curso.Profesor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoUsuario == null)
            {
                return NotFound();
            }

            return View(cursoUsuario);
        }
        [Authorize(Roles = "cliente")]
        // GET: CursoUsuarios/Create
        public async Task<IActionResult> Create(int? id)
        {
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(usr => usr.Email == User.Identity.Name.ToLower());
            Curso curso = await _context.Cursos.FindAsync(id);
            CursoUsuario aux = await _context.CursoUsuarios.FirstOrDefaultAsync(c => c.UsuarioId== usuario.Id && c.CursoId == curso.Id);
            if(aux == null)
            {
                CursoUsuario cursoUsuario = new CursoUsuario();
                cursoUsuario.UsuarioId = usuario.Id;
                cursoUsuario.Usuario = usuario;
                cursoUsuario.CursoId = curso.Id;
                cursoUsuario.Curso = curso;
                _context.Add(cursoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MisCursos));
            }
            return RedirectToAction(nameof(MisCursos));

        }

        // POST: CursoUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,CursoId")] CursoUsuario cursoUsuario)
        {

            if (ModelState.IsValid)
            {
                _context.Add(cursoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MisCursos));
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Ruta", cursoUsuario.CursoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Apellido", cursoUsuario.UsuarioId);
            return View(cursoUsuario);
        }

        // GET: CursoUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoUsuario = await _context.CursoUsuarios.FindAsync(id);
            if (cursoUsuario == null)
            {
                return NotFound();
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Ruta", cursoUsuario.CursoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Apellido", cursoUsuario.UsuarioId);
            return View(cursoUsuario);
        }

       
        // GET: CursoUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoUsuario = await _context.CursoUsuarios
                .Include(c => c.Curso)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoUsuario == null)
            {
                return NotFound();
            }

            return View(cursoUsuario);
        }

        // POST: CursoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cursoUsuario = await _context.CursoUsuarios.FindAsync(id);
            _context.CursoUsuarios.Remove(cursoUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MisCursos));
        }

        private bool CursoUsuarioExists(int id)
        {
            return _context.CursoUsuarios.Any(e => e.Id == id);
        }
    }
}
