using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            // ViewData é uma dicionario no C#, uma coleção de Chave Valor
            ViewData["Title"] = "About_Teste";
            ViewData["Message"] = "Sale WEB MVC App from C# Course";
            ViewData["Email"] = "viniciussalme@gmail.com";

            // Quando o método se chama return "View()", esse método se chama de method builder. Ele é um método auxiliar
            // Que vai retornar um objeto do tipo "IActionResult", no caso atual uma VIEW.
            // O FrameWork vai na pasta VIEW, Home e procura uma página chama About.

            return View();
        }

        public IActionResult Contact()
        {
           
            ViewData["Message"] = "Your contact page.";

            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
