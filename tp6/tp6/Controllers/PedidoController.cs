using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using tp6.Models;
using tp6.ViewModel;

namespace tp6.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {

            RepoPedidos repo = new RepoPedidos();
            PedidoViewModel Pedido = new PedidoViewModel()
            {
                ListadoDePedidos = repo.GetAll(id),
                IdCliente = id,
                CadeteCargado = repo.Cad(id),
                IdCadete = repo.IDCad(id)
            };
            return View(Pedido);
        }

        public IActionResult CargaPedido(PedidoViewModel pe)
        {
            RepoPedidos repo = new RepoPedidos();
            Pedido Pedido = new Pedido()
            {
                Numpedido = pe.IdPedido,
                Estado_actual = pe.Estado_actual,
                Obs = pe.Observacion,
                NCliente = new Cliente()
                { 
                    Id = pe.IdCliente
                }
            };

            repo.Alta(Pedido, pe.IdCadete);
            return Redirect("/Pedido/Index?id=" + pe.IdCliente);
        }
        public IActionResult ModificarPedido(int _idPedido, int _idCliente)
        {
            return View(new PedidoViewModel{ IdPedido = _idPedido, IdCliente = _idCliente});
        }
        public IActionResult Modificar(PedidoViewModel pe)
        {
            RepoPedidos repo = new RepoPedidos();
            repo.Modificacion(pe);
            return Redirect("/Pedido/Index?id=" + pe.IdCliente);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
