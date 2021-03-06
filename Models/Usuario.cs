﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Correo electrónico")]
        [EmailAddress(ErrorMessage = "El campo debe ser una dirección de correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }


        [Display(Name = "Contraseña")]
        public byte[] Contrasenia { get; set; }

        public String Role { get; set; }
        [Display(AutoGenerateField = false)]
        public List<CursoUsuario> CursoUsuarios { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }

        
    }

}
