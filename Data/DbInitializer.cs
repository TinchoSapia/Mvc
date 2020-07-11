using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TpMVC.Models;

namespace TpMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(ELearningDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Cursos.Any())
            {
                return;   
            }




            
            byte[] data = System.Text.Encoding.ASCII.GetBytes("qwer1234");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            Usuario usuario1 = new Usuario()
            {
                Nombre = "Martin",
                Apellido = "SapiaAdministrador",
                Email = "administrador@administrador.com",
                Contrasenia = data,
                Role = "administrador"
                
            };
            context.Usuarios.Add(usuario1);

            data = System.Text.Encoding.ASCII.GetBytes("qwer1234");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            Usuario usuario2 = new Usuario()
            {
                Nombre = "Martin",
                Apellido = "SapiaCliente",
                Email = "cliente@cliente.com",
                Contrasenia = data,
                Role = "cliente",
            };
            context.Usuarios.Add(usuario2);
            var Basico = new Nivel()
            {
                Nombre = "Basico",
                ClaseCss = "LightGreen"

            };
            context.Niveles.Add(Basico);

            var Intermedio = new Nivel()
            {
                Nombre = "Intermedio",
                ClaseCss = "PaleGoldenRod"
            };
            context.Niveles.Add(Intermedio);

            var Avanzado = new Nivel()
            {
                Nombre = "Avanzado",
                ClaseCss = "INDIANRED"
            };
            context.Niveles.Add(Avanzado);

            var Profesor1 = new Profesor()
            {
                Nombre = "Martin",
                Apellido = "Perez"
            };
            context.Profesores.Add(Profesor1);

            var Profesor2 = new Profesor()
            {
                Nombre = "Alejandro",
                Apellido = "Sanchez"
            };
            context.Profesores.Add(Profesor2);

            var Video = new Video() 
            {
                ServidorStreaming = "Youtube",
                Url ="http://www.youtube.com",
                Duracion = 113
            };
            context.Videos.Add(Video);

            var Video2 = new Video()
            {
                ServidorStreaming = "Udemy",
                Url = "http://www.Udemy.com",
                Duracion = 54
            };
            context.Videos.Add(Video2);
            var Lenguaje1 = new Lenguaje()
            {
                Nombre = "Java",
                Version = "8"
            };
            context.Lenguajes.Add(Lenguaje1);
            var Lenguaje2 = new Lenguaje()
            {
                Nombre = "JavaScript",
                Version = "ECMAScript 2016"
            };
            context.Lenguajes.Add(Lenguaje2);
            var Lenguaje3 = new Lenguaje()
            {
                Nombre = "C#",
                Version = ".NET MVC Core 2.1"
            };
            context.Lenguajes.Add(Lenguaje3);
            var Curso1 = new Curso()
            {
                Titulo = "Variables en Java",
                Lenguaje = Lenguaje1,
                Nivel = Basico,
                Profesor = Profesor1,
                AnioPublicado = 2018,
                Video = Video2,
                Ruta = " ",
                CantSubscriptos = 1
                
            };
            context.Cursos.Add(Curso1);

            var Curso2 = new Curso()
            {
                Titulo = "Variables en JavaScript",
                Lenguaje = Lenguaje2,
                Nivel = Intermedio,
                Profesor = Profesor2,
                AnioPublicado = 2020,
                Video = Video,
                Ruta = " ",
                CantSubscriptos = 1
            };
            context.Cursos.Add(Curso2);
            var Curso3 = new Curso()
            {
                Titulo = "Variables en C#",
                Lenguaje = Lenguaje3,
                Nivel = Avanzado,
                Profesor = Profesor1,
                AnioPublicado = 2020,
                Video = Video,
                Ruta = "/1 ",
                CantSubscriptos = 1
            };
            context.Cursos.Add(Curso3);


            context.CursoUsuarios.Add(new CursoUsuario() { Usuario = usuario2, Curso = Curso1, });
            context.CursoUsuarios.Add(new CursoUsuario() { Usuario = usuario2, Curso = Curso2 });
            context.CursoUsuarios.Add(new CursoUsuario() { Usuario = usuario2, Curso = Curso3 });

            context.SaveChanges();
        }
    }
}
