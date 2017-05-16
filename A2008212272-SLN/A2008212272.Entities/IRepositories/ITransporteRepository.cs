using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface ITransporteRepository : IRepository<Transporte>
    {

        IEnumerable<Transporte> GetClassificatedTransporte(TipoTransporte tipoTransporte);
        IEnumerable<Transporte> GetClassificatedTransporte(CategoriaTransporte categoriaTransporte);
        IEnumerable<Transporte> GetTransporteByTipoTransporte(string tipoTransporte);
        IEnumerable<Transporte> GetTransporteByCategoriaTransporte(string categoriaTransporte);


    }
}
