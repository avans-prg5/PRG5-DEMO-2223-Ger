using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDomain.Models;

namespace MVC_Project_2022_10_02.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: HobbiesController
        public ActionResult Index()
        {
            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                return View(context.Hobbies.ToList());
            }
        }

        // GET: HobbiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HobbiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HobbiesController/Create
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

        // GET: HobbiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HobbiesController/Edit/5
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

        // GET: HobbiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HobbiesController/Delete/5
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
