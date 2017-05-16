using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface IVentaPaqueteRepository : IRepository<VentaPaquete>
    {

        IEnumerable<VentaPaquete> GetClassificatedVentaPaquete(ComprobantePago comprobantePago);
        IEnumerable<VentaPaquete> GetClassificatedVentaPaquete(MedioPago medioPago);
        IEnumerable<VentaPaquete> GetClassificatedVentaPaquete(Paquete paquete);
        IEnumerable<VentaPaquete> GetVentaPaqueteByTipoComprobante(string tipoComprobante);
        IEnumerable<VentaPaquete> GetVentaPaqueteByMedioPago(string medioPago);
        IEnumerable<VentaPaquete> GetVentaPaqueteByPaquete(string paquete);

    }
}
