using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public abstract class Persona
    {
        public int PersonaId { get; set; }

        public string Nombres { get; set; }
        public string ApePat { get; set; }
        public string ApeMat { get; set; }
        public string email { get; set; }
        public int Celular { get; set; }
        public string Dirección { get; set; }
        public int Dni { get; set; }


    }
}
