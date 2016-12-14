using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            var today = DateTime.Now;
            ViewBag.Date = today.ToString("MMM dd, yyyy");
            ViewBag.Time = today.ToString("hh:mm tt");
            return View();
        }
    }
}
