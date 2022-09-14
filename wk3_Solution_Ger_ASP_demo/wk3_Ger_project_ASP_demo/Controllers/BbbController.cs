using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using wk1_solution_GER_Telefoonboekje;
using MyDomain;

namespace wk3_Ger_project_ASP_demo.Controllers
{
    public class BbbController : Controller
    {
        

        public IActionResult Index()
        {
            ViewBag.Title = "Title van de pagina";
            ViewBag.Message = "Zeg de volgende zin 10x heel snel";
            ViewBag.Sentence = "De kat die krabt de krullen van de trap!";

            return View();
        }
        public IActionResult PrintLines(string line, int numTimes = 1)
        {
            ViewData["Message"] = line;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult PrintBook()
        {
            Book book = new();
            return View(book.GetPeople());
        }

    }
}
