using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webproject_GER_Telefoonboekje.Controllers
{
    public class MyEmptyController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string WelcomeTo(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

 

    }
}
