using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using MVCEngiBeering.Models;

namespace MVCEngiBeering.Controllers
{
    public class MachineController : Controller
    {
        private MvcMachineContext _mvcMachineContext;

        public MachineController(MvcMachineContext mvcMachineContext)
        {
            _mvcMachineContext = mvcMachineContext;
        }

        public IActionResult Get(int id)
        {

            BBMachine bbMachine = _mvcMachineContext.machines.First();
            
            return View(bbMachine);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}