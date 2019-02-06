using RevisaoApp.Domain.Entities;
using RevisaoApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        
        public HomeController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
        
        public ActionResult Index()
        {
            IEnumerable<Usuario> list = _usuarioService.GetAll().ToList();
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