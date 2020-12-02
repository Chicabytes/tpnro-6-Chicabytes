using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp6.Models;
namespace tp6.ViewModel
{
    public class PedidoViewModel
    {
        public int IdPedido { get; set; }
        public TipoPedido TPedido { get; set; }
        public Estado Estado_actual { get; set; }
        public int IdCliente { get; set; }
        public int IdCadete { get; set; }
        public Cadete CadeteCargado { get; set; }
        public string Observacion { get; set; }
        public List<Pedido> ListadoDePedidos { get; set; }
        public List<Cadete> InfoCadetes(TipoPedido PedidoCliente)
        {
            RepoCadetes repo = new RepoCadetes();
            List<Cadete> LCadete = repo.Buscar(PedidoCliente);
            CadeteViewModel Cadetes = new CadeteViewModel()
            {
                ListaCadetes = LCadete
            };
            return Cadetes.ListaCadetes;
        }
    }
}
