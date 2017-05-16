using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface IComprobantePagoRepository : IRepository<ComprobantePago>
    {
        IEnumerable<ComprobantePago> GetClassificatedComprobantePago(TipoComprobante tipoComprobante);
        IEnumerable<ComprobantePago> GetComprobantePagoByTipoComprobante(string tipoComprobante);

    }
}
