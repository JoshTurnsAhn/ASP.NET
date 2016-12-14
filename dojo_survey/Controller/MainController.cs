using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dojosurvey.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult index()
        {
    
            return View();
        }
         [HttpPost("result")]
        public IActionResult result(string name, string Location, string langauge, string comment)
        {
            ViewBag.name = name;
            ViewBag.Location = Location;
            ViewBag.langauge = langauge;
            ViewBag.comment = comment;
            return View("result");
        }
        
    }
}
