using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyDomain.Models;
using System.Net;

namespace MVC_Project_2022_10_02.Controllers
{
    public class PersonsController : Controller
    {
        // GET: PersonsController
        public ActionResult Index()
        {
            using (var context = new ContextFactory().CreateDbContext(new string[0]))
            {
                return View(context.Persons.ToList());
            }
        }

        // GET: PersonsController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                using (var context = new ContextFactory().CreateDbContext(new string[0]))
                {
                    return View(context.Persons.FirstOrDefault(p => p.Id == id));
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Index", "Home");
            }

        }

        // GET: PersonsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person model)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                    using (var context = new ContextFactory().CreateDbContext(new string[0]))
                    {
                        context.Persons.Add(model);
                        context.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                //}
                //else
                //{
                //    return View(model);
                //}
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PersonsController/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                using (var context = new ContextFactory().CreateDbContext(new string[0]))
                {
                    return View(context.Persons.FirstOrDefault(p => p.Id == id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: PersonsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Person model)
        {
            try
            {
                using (var context = new ContextFactory().CreateDbContext(new string[0]))
                {
                    context.Persons.Update(model);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Persons");
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        
        }

        // GET: PersonsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonsController/Delete/5
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
