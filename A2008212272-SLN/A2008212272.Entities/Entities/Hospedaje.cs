using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities
{
    public class Hospedaje : ServicioTuristico
    {
        public int HospedajeId { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public TipoHospedaje Tipo { get; set; }
        public CalificacionHospedaje Calificacion { get; set; }
        public CategoriaHospedaje Categoria { get; set; }
        public ServicioHospedaje Servicio { get; set; }


        public Hospedaje()
        {
            Tipo = new TipoHospedaje();
            Calificacion = new CalificacionHospedaje();
            Categoria = new CategoriaHospedaje();
            Servicio = new ServicioHospedaje();
        }
    }
}

