using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpMVC.Models
{
    public class CursoProgramador
    {
        public int Id { get; set; }

        public int ProgramadorId { get; set; }
        public Programador Programador { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
