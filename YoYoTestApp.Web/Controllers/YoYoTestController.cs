using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YoYoTestApp.Web.Models;

namespace YoYoTestApp.Web.Controllers
{
    public class YoYoTestController : Controller
    {
        private readonly ILogger<YoYoTestController> _logger;

        public YoYoTestController(ILogger<YoYoTestController> logger)
        {
            _logger = logger;
        }

        public IActionResult YoYoTest()
        {
            return View("YoYoTest");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
