using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class AltaPedidoViewModel
    {
        public Estado Estado_actual { get; set; }
        public int IdCliente { get; set; }
        public string Observacion { get; set; }
        public List<Pedido> ListadoDePedidos { get; set; }
        
    }
}
