﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp6.Addon;
using tp6.Models;
using tp6.ViewModel;
using tp6.Controllers;


namespace tp6.Controllers
{
    public class UserController : BaseController
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;

        public UserController(ILogger<UserController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Ingreso(UserViewModel usuarioVM)
        {
            try
            {
                RepoUsuario repoUsuario = new RepoUsuario();
                User usuario = _mapper.Map<User>(usuarioVM);

                if (repoUsuario.Validacion(usuario) && !IsSesionIniciada())
                {
                    SetSesion(usuario);
                }

                ViewBag.UserLogueado = GetRol();
                return Redirect("/Home/Index");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
            
        }

        public IActionResult AltaUser()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult CrearUsuario(UserViewModel UsuarioVM)
        {
            try
            {
                string mensaje = "";
                if (ModelState.IsValid)
                {
                    RepoUsuario repoUsuario = new RepoUsuario();
                    User usuario = _mapper.Map<User>(UsuarioVM);
                    if (!repoUsuario.Validacion(usuario))
                    {
                        repoUsuario.AltaUsuario(usuario);

                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        mensaje = "El usuario ya existe";
                        return Content(mensaje);
                    }
                }
                else
                {
                    mensaje = "Se produjo un error, faltan ingresar datos";
                }
                return Content(mensaje);

            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }

        }
        public IActionResult Desloguearse()
        {
            Logout();

            return Redirect("Index");
        }
    }
}
