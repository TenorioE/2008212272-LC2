using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities
{
    public class ComprobantePago
    {
        public int ComprobanteId { get; set; }
        public string Descripcion { get; set; }
        public TipoComprobante TipoComprobante { get; set; }

        public ComprobantePago()
        {
            TipoComprobante = new TipoComprobante();
        }
    }
}

