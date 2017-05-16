﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities
{
    public class Alimentacion : ServicioTuristico
    {
        public int AlimentacionId { get; set; }
        public CategoriaAlimentacion Categoria { get; set; }


        public Alimentacion()
        {
            Categoria = new CategoriaAlimentacion();
        }
    }
}
