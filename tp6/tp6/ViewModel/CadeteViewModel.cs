using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class CadeteViewModel
    {
        public TipoTransporte TipoT { get; set; }
        public int idCadete { get; set; }
        public string NombreCadete { get; set; }
        public List<Cadete> ListaCadetes { get; set; }
    }
}
