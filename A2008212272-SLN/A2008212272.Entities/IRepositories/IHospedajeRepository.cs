using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface IHospedajeRepository : IRepository<Hospedaje>
    {

        IEnumerable<Hospedaje> GetClassificatedHospedaje(TipoHospedaje tipoHospedaje);
        IEnumerable<Hospedaje> GetClassificatedHospedaje(CalificacionHospedaje calificacionHospedaje);
        IEnumerable<Hospedaje> GetClassificatedHospedaje(CategoriaHospedaje categoriaHospedaje);
        IEnumerable<Hospedaje> GetClassificatedHospedaje(ServicioHospedaje servicioHospedaje);


        IEnumerable<Hospedaje> GetHospedajeByTipoHospedaje(string tipoHospedaje);
        IEnumerable<Hospedaje> GetHospedajeByCalificacionHospedaje(string calificacionHospedaje);
        IEnumerable<Hospedaje> GetHospedajeByCategoriaHospedaje(string categoriaHospedaje);
        IEnumerable<Hospedaje> GetHospedajeByServicioHospedaje(string servicioHospedaje);

    }
}
