using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlfredoLotar.Livro.AspnetMvc;
namespace AppCapitulo1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return Content("<h1>Olá mundo!</h1>");
        //}

        public ActionResult Index()
        {
            ViewBag.Mensagem = "ASP.NET MVC!";
            var model = new Cidades()
            {
                CidadeID = 1,
                Nome = "São Paulo",
                Estado = "SP"
            };
            return View(model);

        }

        public ActionResult Details(int id)
        {
            ViewBag.Mensagem = "Detalhes id = " + id;
            return View();
        }

    }
}

