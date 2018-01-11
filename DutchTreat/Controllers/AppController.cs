using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happend");

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happen");

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(object model)
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
    }
}