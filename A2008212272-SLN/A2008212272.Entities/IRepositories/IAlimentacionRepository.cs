using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities.IRepositories
{
    public interface IAlimentacionRepository : IRepository<Alimentacion>
    {

        IEnumerable<Alimentacion> GetClassificatedAlimentacion(CategoriaAlimentacion categoriaAlimentacion);
        IEnumerable<Alimentacion> GetAlimentacionByCategoriaAlimentacion(string categoriaAlimentacion);

    }
}
