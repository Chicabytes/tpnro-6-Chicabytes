using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class AltaPedidoViewModel
    {
        public List<CadeteViewModel> LCadetesVM { get; set; }
        public List<ClienteViewModel> LClientesVM { get; set; }
        public TipoPedido TPedido { get; set; }
        public string Observacion { get; set; }
        public ClienteViewModel NCliente { get; set; }
        public CadeteViewModel NCadete { get; set; }
    }
}
