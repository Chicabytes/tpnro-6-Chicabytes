﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using tp6.Models;
using tp6.ViewModel;

namespace tp6.Controllers
{
	public class ClienteController : Controller
	{
		private readonly ILogger<ClienteController> _logger;
		private readonly IMapper _mapper;

		public ClienteController(ILogger<ClienteController> logger, IMapper mapper)
		{
			_logger = logger;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			RepoClientes repo = new RepoClientes();
			List<Cliente> ListaClientes = repo.GetAll();
			List<ClienteViewModel> ClientesVM = _mapper.Map<List<ClienteViewModel>>(ListaClientes);
			return View(ClientesVM);
		}
		[HttpPost]
		public IActionResult CargaCliente(ClienteViewModel _Cli)
		{
			try
			{
				RepoClientes repo = new RepoClientes();
				Cliente Cli = _mapper.Map<Cliente>(_Cli);
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
			return View(new ClienteViewModel());
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
		public IActionResult Modificar(ClienteViewModel _Cli)
		{
			RepoClientes repo = new RepoClientes();
			Cliente Cli = _mapper.Map<Cliente>(_Cli);
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
