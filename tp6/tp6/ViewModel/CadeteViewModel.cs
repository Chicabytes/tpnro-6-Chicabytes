﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class CadeteViewModel
    {
        public TipoTransporte TipoT { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Cadete> ListaCadetes { get; set; }
    }
}
