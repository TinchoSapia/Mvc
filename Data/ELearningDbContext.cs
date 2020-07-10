using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TpMVC.Models;

namespace TpMVC.Data
{
    public class ELearningDbContext : DbContext
    { 

        public ELearningDbContext(DbContextOptions<ELearningDbContext> options) : base(options)
        {

        }

        public DbSet<Lenguaje> Lenguajes { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Programador> Programadores { get; set; }
        public DbSet<CursoUsuario> CursoUsuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Role> Roles { get; set; }

    }   
}
