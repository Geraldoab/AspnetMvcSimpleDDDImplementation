using RevisaoApp.Application.Interfaces;
using RevisaoApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioAppService _usuarioService;
        
        public HomeController(IUsuarioAppService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
        
        public ActionResult Index()
        {
            int count = _usuarioService.Count();
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.CodigoUsuario = 0;
            usuarioViewModel.NomeUsuario = "teste";

            _usuarioService.Add(usuarioViewModel);

            count = _usuarioService.Count();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}