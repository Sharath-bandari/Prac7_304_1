
using Microsoft.AspNetCore.Mvc;
using Feedback_Management.Models;

namespace Feedback_Management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Feedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
                ModelState.Clear();
                return View(new Feedback());
            }

            return View(feedback);
        }
    }
}
