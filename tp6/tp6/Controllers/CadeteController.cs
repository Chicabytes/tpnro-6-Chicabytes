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
using AutoMapper;

namespace tp6.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;
        private readonly IMapper _mapper;
        
        public CadeteController(ILogger<CadeteController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            RepoCadetes repo = new RepoCadetes();
            List<Cadete> ListaCadetes = repo.GetAll();
            List<CadeteViewModel> ListaVM = _mapper.Map<List<CadeteViewModel>>(ListaCadetes);
            return View(ListaVM);
        }
        [HttpPost]
        public IActionResult CargaCadete(CadeteViewModel _Cad)
        {
            try
            {
                RepoCadetes repo = new RepoCadetes();
                Cadete cad = _mapper.Map<Cadete>(_Cad);
                repo.Alta(cad);
                return Redirect("/Cadete/Index");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult AltaCadete()
        {
            return View(new CadeteViewModel());
        }
        [HttpPost]
        public IActionResult BajaCadete(int _id)
        {
            try
            {
                RepoCadetes repo = new RepoCadetes();
                repo.Baja(_id);
                return Redirect("/Cadete/Index");
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Content(error);
            }
        }
        public IActionResult ModificarCadete(int _id)
        {
            RepoCadetes repo = new RepoCadetes();
            CadeteViewModel cad = _mapper.Map<CadeteViewModel>(repo.Buscar(_id));
            return View(cad);
        }
        [HttpPost]
        public IActionResult Modificar(CadeteViewModel _cad)
        {
            RepoCadetes repo = new RepoCadetes();
            Cadete cad = _mapper.Map<Cadete>(_cad);
            repo.Modificar(cad);
            return Redirect("/Cadete/Index");
        }
        [HttpPost]
        public IActionResult GestionDePedidos(int idCadete, TipoTransporte tipo)
        {
            CadetesYPedidosViewModel Cadetes = new CadetesYPedidosViewModel();
            {
                Cadetes.IdCadete = idCadete;
                switch (tipo)
                {
                    case TipoTransporte.Auto:
                        Cadetes.TipoPed = TipoPedido.Delicado;
                        break;
                    case TipoTransporte.Moto:
                        Cadetes.TipoPed = TipoPedido.Express;
                        break;
                    case TipoTransporte.Bicicleta:
                        Cadetes.TipoPed = TipoPedido.Ecologico;
                        break;
                }
            }
            return View(Cadetes);
        }
        [HttpPost]
        public IActionResult MisPedidos(int idCadete, TipoPedido TipoP)
        {
            CadetesYPedidosViewModel CadetesYPedidosVM = new CadetesYPedidosViewModel();
            RepoPedidos repo = new RepoPedidos();
            CadetesYPedidosVM.ListaPedidos = repo.GetAll(TipoP, idCadete);
            return View(CadetesYPedidosVM);
        }
        [HttpPost]
        public IActionResult ListaDePedidos(int idCadete, TipoPedido TipoP)
        {
            RepoPedidos repo = new RepoPedidos();
            CadetesYPedidosViewModel CadetesYPedidosVM = new CadetesYPedidosViewModel() 
            {
                ListaPedidos = repo.GetAll(TipoP),
                IdCadete = idCadete
            };
            return View(CadetesYPedidosVM);
        }
        public IActionResult ModificarEstado(int idCadete, int idPedido, EstadoPedido estado)
        {
            CadetesYPedidosViewModel CyPedidoVM = new CadetesYPedidosViewModel()
            {
                Estado = estado,
                IdPedido = idPedido,
                IdCadete = idCadete
            };
            return View(CyPedidoVM);
        }

        public IActionResult NuevoEstado(CadetesYPedidosViewModel CadyPed)
        {
            RepoPedidos repo = new RepoPedidos();
            repo.ModificarEstado(CadyPed.IdPedido, CadyPed.Estado);
            return Redirect("/Cadete/");
        }
        public IActionResult AgregarPedido(int idPedido, int idCadete)
        {
            RepoPedidos repo = new RepoPedidos();
            repo.AgregarCadete(idPedido, idCadete);
            return Redirect("/Cadete/");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
