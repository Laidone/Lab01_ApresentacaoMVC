/*
 Nome: Laidone Mendes de Carvalho
 Lab01_ApresentacaoMVC
 */

using Microsoft.AspNetCore.Mvc;
using Lab01_ApresentacaoMVC.Models;

namespace Lab01_ApresentacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        /*public string Index()
        {
            return "Hello MVC!";
        }*/
        public ActionResult Index()
        {
            @ViewBag.Agora = "Hello MVC! " + DateTime.Now;
            return View();
        }
        public ActionResult Filme()
        {
            Filme filme = new Filme()
            {
                Titulo = "Inglourious Basterds",
                Genero = "War",
                Assistido = true
            };
            return View(filme);
        }

    }
}
