﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class CadeteViewModel
    {
        public TipoTransporte TipoT { get; set; }
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 7)]
        public string Telefono { get; set; }
        public List<Cadete> ListaCadetes { get; set; }
    }
}
