using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpMVC.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        public string ServidorStreaming { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(300, ErrorMessage = "La longitud máxima es de 300 caracteres")]
        [Display(Description = "Url del video")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Description = "Duracion en minutos")]
        public int Duracion { get; set; }
    }
}
