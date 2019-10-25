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
            List<BBMachineViewModel> machines = new List<BBMachineViewModel>();
            foreach (var machine in _mvcEngibeeringContext.machines.ToList())
            {
                BBMachineViewModel temp = new BBMachineViewModel();
                temp.currentamount = machine.currentamount;
                temp.currentproduct = machine.currentproduct;
                temp.currentspeed = machine.currentspeed;
                temp.currentstate = machine.currentstate;
                temp.id = machine.id;
                temp.uniqueid = machine.uniqueid;
                machines.Add(temp);
            }
            
            return View(machines);
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
