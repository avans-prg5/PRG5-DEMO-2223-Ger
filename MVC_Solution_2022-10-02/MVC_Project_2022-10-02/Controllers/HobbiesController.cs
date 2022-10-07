using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_2022_10_02.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: HobbiesController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: HobbiesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HobbiesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HobbiesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HobbiesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HobbiesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HobbiesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HobbiesController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
