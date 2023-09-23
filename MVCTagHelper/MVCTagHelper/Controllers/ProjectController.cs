using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelper.Controllers
{
    public class ProjectController : Controller
    {
        // GET: ProjectController
        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Tabs()
        {
            ViewData["data1"] = "Tom and jerry are good friends";
            return View();
        }
        public IActionResult ChildList()
        {
            return View();
        }



        public IActionResult ChildViewData()
        {
            return View();
        }



        public IActionResult Score()
        {
            return View();
        }



        public IActionResult MyView()
        {
            return View();
        }



        // GET: ProjectController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: ProjectController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: ProjectController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ProjectController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProjectController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ProjectController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProjectController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
