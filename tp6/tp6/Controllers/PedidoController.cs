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
            AltaPedidoViewModel Pedido = new AltaPedidoViewModel()
            {
                ListadoDePedidos = repo.GetAll(id),
                IdCliente = id,
             
            };
            
            return View(Pedido);
        }

        public IActionResult AltaPedido(int IdPedido)
        {
            return View(new Pedido());
        }
        public IActionResult CargaPedido(AltaPedidoViewModel pe)
        {
            RepoPedidos repo = new RepoPedidos();
            Pedido Pedido = new Pedido()
            {
                Estado_actual = pe.Estado_actual,
                Obs = pe.Observacion,
                NCliente = new Cliente()
                { 
                    Id = pe.IdCliente
                }
            };

            repo.Alta(Pedido);
            return Redirect("/Pedido/Index?id=" + pe.IdCliente);
        }

        public IActionResult ModificarPedido()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
