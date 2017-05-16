using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities
{
    public class Empleado : Persona
    {
        public int EmpleadoId { get; set; }
        public DateTime FecIngreso { get; set; }
        public String Cargo { get; set; }

    }
}
