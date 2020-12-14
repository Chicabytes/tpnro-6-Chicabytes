using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Collections.Generic;
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

        public IActionResult Index()
        {
            try 
            { 
                RepoPedidos repo = new RepoPedidos();
                PedidoViewModel Pedidos = new PedidoViewModel()
                {
                    ListadoDePedidos = repo.GetAll()
                };
                return View(Pedidos);
            }
            catch (System.Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AltaPedido()
        {
            try
            {
                RepoPedidos repo = new RepoPedidos();
                RepoCadetes repoCad = new RepoCadetes();
                RepoClientes repoCli = new RepoClientes();
                PedidoViewModel Pedido = new PedidoViewModel()
                {
                    ListadoDePedidos = repo.GetAll(),
                    LCadetesVM = _mapper.Map<List<CadeteViewModel>>(repoCad.GetAll()),
                    LClientesVM = _mapper.Map<List<ClienteViewModel>>(repoCli.GetAll())
                };
                return View(Pedido);
            }
            catch (System.Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult CargaPedido(PedidoViewModel pe)
        {
            try
            {
                RepoPedidos repo = new RepoPedidos();
                Pedido Pedido = new Pedido();
                Pedido = _mapper.Map<Pedido>(pe);
                repo.Alta(Pedido);
                return Redirect("/Pedido/Index");
            }
            catch (System.Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult ModificarPedido(int _idPedido)
        {
            return View(new AltaPedidoViewModel { NumeroDePedido = _idPedido});
        }
        [HttpPost]
        public IActionResult Modificar(AltaPedidoViewModel pe)
        {
            try
            { 
                RepoPedidos repo = new RepoPedidos();
                Pedido Pe = _mapper.Map<Pedido>(pe);
                repo.Modificacion(Pe);
                return Redirect("/Pedido/Index");
            }
            catch (System.Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult BajaPedido(int idPed)
        {
            try
            { 
                RepoPedidos repo = new RepoPedidos();
                repo.Baja(idPed);
                return Redirect("/Pedido/Index");
            }
            catch (System.Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
