using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOLO
{
    public class Materia
    {
        public Materia(string seccion, bool status)
        {
            Seccion = seccion;
            Status = status;

        }
        public Materia(string seccion, bool status, Materia[] materias)
        {
            Seccion = seccion;
            Status = status;
            Requisitos.AddRange(materias);
           
        }
        public String Seccion { get; set; }
        public bool Status { get; set; }

        public List<Materia> Requisitos;
    }
}
