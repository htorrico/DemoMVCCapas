using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonControllercs
        public ActionResult Demo()
        {
            return View();
        }

        // GET: PersonControllercs
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonControllercs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonControllercs/Create
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

        // GET: PersonControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonControllercs/Edit/5
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

        // GET: PersonControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonControllercs/Delete/5
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
