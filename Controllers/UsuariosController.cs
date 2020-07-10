using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TpMVC.Data;
using TpMVC.Models;

namespace TpMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ELearningDbContext _context;

        public UsuariosController(ELearningDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Disponibles", "CursoUsuarios");
            }
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("email", "password")] string email, string password)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Disponibles", "CursoUsuarios");
            }
            string returnUrl = TempData["returnUrl"] as string;
            Usuario usuario = await _context.Usuarios.FirstOrDefaultAsync(usr => usr.Email == email.ToLower());

            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                
                try
                {
                    
                    if (usuario.Contrasenia.SequenceEqual(data))
                    {
                        var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, email.ToLower()),
                                new Claim(ClaimTypes.Role, usuario.Role.ToString()),
                            };
                        
                        var authProperties = new AuthenticationProperties
                        {
                            IsPersistent = true,
                        };
                        var claimsIdentity = new ClaimsIdentity(
                            claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                        usuario.FechaUltimoAcceso = DateTime.Now;
                        await _context.SaveChangesAsync();
                      
                        if (!string.IsNullOrWhiteSpace(returnUrl))
                            return Redirect(returnUrl);

                        return RedirectToAction("Disponibles", "CursoUsuarios");
                    }
                    
                }
                catch (NullReferenceException)
                {

                }
 
            }
            ViewBag.Error = "Usuario o contraseña incorrectos";
            ViewBag.Email = email.ToLower();
            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login","Usuarios");
        }

        // GET: Usuarios/SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: Usuarios/SignUp
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("Id,Email,Nombre,Apellido")] Usuario usuario, string password, string Email)
        {
            Usuario usuarioAux = _context.Usuarios.FirstOrDefault(usr => usr.Email == Email.ToLower());
            if (usuarioAux==null) { 

                if (!string.IsNullOrWhiteSpace(password))
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    usuario.Role = "cliente";
                    usuario.Contrasenia = data;
                    usuario.Email = Email.ToLower();
                    if (ModelState.IsValid)
                    {
                        _context.Add(usuario);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Index", "Cursos");
                    }
                }
                else
                {
                    ModelState.AddModelError("Contrasenia", "La contraseña no puede estar vacía");
                }

            }
            else
            {
                ModelState.AddModelError("Email", "Ya hay un usuario con ese Email");
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email.ToLower() == User.Identity.Name);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        public async Task<Usuario> UsuarioLogeado()
        {
         
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email.ToLower() == User.Identity.Name);
             return usuario;
        }
        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Nombre,Apellido")] Usuario usuario, string password)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);

                usuario.Contrasenia = data;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "CursoUsuarios");
            }
            return View(usuario);
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}