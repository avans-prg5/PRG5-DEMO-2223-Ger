using Microsoft.AspNetCore.Mvc;

namespace wk3_Ger_project_ASP_demo.Controllers
{
    public class AaaController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Controller without a view: Aaa";
        }
    }
}
