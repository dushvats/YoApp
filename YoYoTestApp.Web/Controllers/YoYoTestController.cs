using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YoYoTestApp.Application.Interfaces;
using YoYoTestApp.Web.Models;
using YoYoTestApp.Web.ViewModels;

namespace YoYoTestApp.Web.Controllers
{
    public class YoYoTestController : Controller
    {
        private readonly ILogger<YoYoTestController> _logger;
        private readonly IShuttleService _shuttleService;
        public YoYoTestController(ILogger<YoYoTestController> logger, IShuttleService shuttleService)
        {
            _logger = logger;
            _shuttleService = shuttleService;
        }

        public IActionResult YoYoTest()
        {
            var yoYoTestViewModel = new YoYoTestViewModel();
            yoYoTestViewModel.Shuttles = _shuttleService.GetAllShuttles().Result;
            yoYoTestViewModel.MaxValue = _shuttleService.MaxValueForTimer().Result;
            return View("YoYoTest", yoYoTestViewModel);
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
