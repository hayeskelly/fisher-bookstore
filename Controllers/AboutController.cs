using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controllers Index method.");
        }

        public IActionResult History ()
        {
            return Content("This is the About controllers History method.");
        }

        public IActionResult Location ()
        {
            return Content("This is the About controllers Location method.");
        }
    }

}