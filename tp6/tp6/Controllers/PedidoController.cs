using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using tp6.Models;
using tp6.ViewModel;

namespace tp6.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IMapper _mapper;

        public PedidoController(ILogger<PedidoController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index(int id)
        {

            RepoPedidos repo = new RepoPedidos();
            PedidoViewModel Pedido = new PedidoViewModel()
            {
                ListadoDePedidos = repo.GetAll(id),
                IdCliente = id
            };
            return View(Pedido);
        }
        public IActionResult Index2()
        {
            RepoPedidos repo = new RepoPedidos();
            return View(repo.GetAll());
        }
        [HttpPost]
        public IActionResult CargaPedido(PedidoViewModel pe)
        {
            RepoPedidos repo = new RepoPedidos();
            Pedido Pedido = _mapper.Map<Pedido>(pe);
            repo.Alta(Pedido, pe.IdCadete);
            return Redirect("/Pedido/Index?id=" + pe.IdCliente);
        }
        [HttpPost]
        public IActionResult ModificarPedido(int _idPedido, int _idCliente)
        {
            return View(new PedidoViewModel { IdPedido = _idPedido, IdCliente = _idCliente });
        }
        [HttpPost]
        public IActionResult Modificar(PedidoViewModel pe)
        {
            RepoPedidos repo = new RepoPedidos();
            Pedido Pe = _mapper.Map<Pedido>(pe);
            repo.Modificacion(Pe);
            return Redirect("/Pedido/Index?id=" + pe.IdCliente);
        }
        [HttpPost]
        public IActionResult BajaPedido(int idPed, int idCli)
        {
            RepoPedidos repo = new RepoPedidos();
            repo.Baja(idPed);
            return Redirect("/Pedido/Index?id=" + idCli);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
