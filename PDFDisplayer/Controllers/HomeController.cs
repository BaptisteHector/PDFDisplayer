using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PDFDisplayer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string url)
        {
            ViewBag.url = url;
            return View();
        }
    }
}
