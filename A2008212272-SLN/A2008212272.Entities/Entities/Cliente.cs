﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Entities
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

    }
}
