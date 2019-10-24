using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;

namespace MVCEngiBeering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MvcEngibeeringContext _mvcEngibeeringContext;

        public HomeController(ILogger<HomeController> logger, MvcEngibeeringContext mvcEngibeeringContext)
        {
            _logger = logger;
            _mvcEngibeeringContext = mvcEngibeeringContext;
        }

        public IActionResult Index()
        {
            IQueryable<int> idQuery = from m in _mvcEngibeeringContext.machines orderby m.id select m.id;
            var machines = from m in _mvcEngibeeringContext.machines select m;
            var machineVM = new BBMachineViewModel();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BBMachine(int submit)
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
