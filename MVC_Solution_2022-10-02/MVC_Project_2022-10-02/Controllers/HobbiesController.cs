using Microsoft.AspNetCore.Mvc;
using MVC_Project_2022_10_02.Models;
using MyDomain.Models;
using ImageConverter = MyDomain.Models.ImageConverter;

namespace MVC_Project_2022_10_02.Controllers
{
    public class HobbiesController : Controller
    {
        private readonly ImageConverter _imageConverter = new ImageConverter();

        // GET: HobbiesController
        public ActionResult Index()
        {
            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                return View(context.Hobbies.OrderBy(h=>h.Titel).ToList());
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
        public ActionResult Create(HobbyViewModel hobbyVM)
        {
            try
            {
                using (var context = new ContextFactory().CreateDbContext(new string[0]))
                { 
                    Hobby model = hobbyVM.Hobby;
                    if (hobbyVM.picPath != null)
                    {
                        model.HobbyImage = _imageConverter.FilePNGToByteArray(hobbyVM.picPath);
                    }
                    context.Hobbies.Add(model);
                    context.SaveChanges();
                }
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
            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                Hobby model = context.Hobbies.Find(id);
                if (model == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
        }

        // POST: HobbiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                try
                {
                    Hobby hobby = context.Hobbies.Find(id);
                    context.Hobbies.Remove(hobby);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }
    }
}
