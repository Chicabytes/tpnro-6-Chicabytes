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
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Cliente> NCliente;
            RepoClientes repo = new RepoClientes();
            NCliente = repo.GetAll();
            return View(NCliente);
        }
        [HttpPost]
        public IActionResult CargaCliente(string Nombre, string Direccion, string Telefono, int TipoEnvio, bool cupon, double costo)
        {
            try
            {
                Cliente Cli = new Cliente();
                Cli.Nombre = Nombre;
                Cli.Direccion = Direccion;
                Cli.Telefono = Telefono;
                switch (TipoEnvio)
                {
                    case 0:
                        Cli.Tipo = TipoPedido.Delicado;
                        break;
                    case 1:
                        Cli.Tipo = TipoPedido.Express;
                        break;
                    case 2:
                        Cli.Tipo = TipoPedido.Ecologico;
                        break;
                }
                RepoClientes repo = new RepoClientes();
                repo.Alta(Cli);
                return Redirect("/Cliente/Index");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult AltaCliente()
        {
            return View(new Cliente());
        }
        [HttpPost]
        public IActionResult BajaCliente(int _id)
        {
            try
            {
                RepoClientes repo = new RepoClientes();
                repo.Baja(_id);
                return Redirect("/Cliente/Index");
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Content(error);
            }
        }
        public IActionResult ModificarCliente(int _id)
        {
            RepoClientes repo = new RepoClientes();
            Cliente Cli = repo.Buscar(_id);
            return View(Cli);
        }
        [HttpPost]
        public IActionResult Modificar(Cliente Cli)
        {
            RepoClientes repo = new RepoClientes();
            repo.Modificar(Cli);
            return Redirect("/Cliente/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
