using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpMVC.Models
{
    public class Lenguaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(10, ErrorMessage = "La longitud máxima es de 20 caracteres")]
        [Display(Description = "Numero de Version del lenguaje")]
        public string Version { get; set; }
    }
}
