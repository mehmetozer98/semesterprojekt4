using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCEngiBeering.Models;

namespace MVCEngiBeering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BBMachineList listOfMachines = new BBMachineList();
        private BBMachine machine = new BBMachine();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int machine)
        {
            this.machine = listOfMachines.machineList[machine];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BBMachine(int submit)
        {
            if (submit != 0)
            {
                this.machine.chosencommand = submit;
            }

            ViewBag.SubmitValue = listOfMachines.machineList[0].chosencommand;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }


}
