using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpMVC.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [MaxLength(100, ErrorMessage = "Se supero la long max")]
        public string Titulo { get; set; }
        [Display(Name = "Año publicado")]
        public int? AnioPublicado { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Ruta del video")]
        public string Ruta { get; set; }

        [Display(Name = "Lenguaje")]
        public int LenguajeId { get; set; }
        public Lenguaje Lenguaje { get; set; }

        [Display(Name = "Nivel")]
        public int NivelId { get; set; }
        public Nivel Nivel { get; set; }
        [Display(Name = "Servidor")]
        public int VideoId { get; set; }
        public Video Video { get; set; }

        [Display(Name = "Programador")]
        public int ProgramadorId { get; set; }
        public Programador Programador { get; set; }
        public List<CursoUsuario> CursoUsuarios { get; set; }

        public string ObtenerUrlCompleto()
        {
                char[] array = Ruta.ToCharArray();
                if (array[0].Equals('/')) {
                    return Video.Url.ToString() + Ruta;
                }
                return Video.Url.ToString() + '/' + Ruta;
        }
}
}
