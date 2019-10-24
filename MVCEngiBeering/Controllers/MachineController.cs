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
            //return _mvcMachineContext.Machine.AsEnumerable();
            //Console.WriteLine("FUUUUUUUUUUUUUUUUUUUUUUUUUUUCK" + id);
            //var bbMachine = _mvcMachineContext.Machine.Find(1);
            
            BBMachine bbMachine = _mvcMachineContext.Machine.First();
            
            return View(bbMachine);
        }

//        public BBMachine Get(int id)
//        {
//            return _mvcMachineContext.Machine.FirstOrDefault(x => x.Id == id);
//        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}