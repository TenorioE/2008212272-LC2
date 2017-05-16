using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface IPaqueteRepository : IRepository<Paquete>
    {
        IEnumerable<Paquete> GetClassificatedPaquete(ServicioTuristico servicioTuristico);

        IEnumerable<Paquete> GetPaqueteByServicioTuristico(string servicioTuristico);

    }
}
