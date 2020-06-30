//using System;
//using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TpMVC.Models;
using TpMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace TpMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ELearningDbContext _context;


        public HomeController(ELearningDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eLearningDbContext = _context.Cursos.Include(c => c.Lenguaje).Include(c => c.Nivel).Include(c => c.Video);
            return View(await eLearningDbContext.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
