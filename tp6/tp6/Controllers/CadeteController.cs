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

namespace tp6.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;
        
        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
            
        }
        public IActionResult Index()
        {
            List<Cadete> NCadetes;
            RepoCadetes repo = new RepoCadetes();
            NCadetes = repo.GetAll();
            return View(NCadetes);
        }
        [HttpPost]
        public IActionResult CargaCadete(string Nombre, string Direccion, string Telefono, int TipoT)
        {
            try
            {
                Cadete cad = new Cadete();
                cad.Nombre = Nombre;
                cad.Direccion = Direccion;
                cad.Telefono = Telefono;
                switch (TipoT)
                {
                    case 0:
                        cad.TipoT = TipoTransporte.Auto;
                        break;
                    case 1:
                        cad.TipoT = TipoTransporte.Moto;
                        break;
                    case 2:
                        cad.TipoT = TipoTransporte.Bicicleta;
                        break;
                }
                RepoCadetes repo = new RepoCadetes();
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
            return View(new Cadete());
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
            Cadete cad = repo.Buscar(_id);
            return View(cad);
        }
        [HttpPost]
        public IActionResult Modificar(Cadete cad)
        {
            RepoCadetes repo = new RepoCadetes();
            repo.Modificar(cad);
            return Redirect("/Cadete/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
