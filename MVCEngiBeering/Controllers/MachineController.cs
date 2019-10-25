using System.Data.Entity;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;
using MVCEngiBeering.ViewModels;

namespace MVCEngiBeering.Controllers
{
    public class MachineController : Controller
    {
        private MvcEngibeeringContext _mvcEngibeeringContext;

        public MachineController(MvcEngibeeringContext mvcEngibeeringContext)
        {
            _mvcEngibeeringContext = mvcEngibeeringContext;
        }

        public IActionResult Get(int id)
        {
            using (var context = _mvcEngibeeringContext)
            {
                var machine = context.machines.Single(m => m.id == id);
                context.machines(machine)
            }
            
            
            
            BBMachine machine = _mvcEngibeeringContext.machines.Find(id);
            BBMachineViewModel temp = new BBMachineViewModel
            {
                currentamount = machine.currentamount,
                currentproduct = machine.currentproduct,
                currentspeed = machine.currentspeed,
                currentstate = machine.currentstate,
                id = machine.id,
                uniqueid = machine.uniqueid
            };


            return View(temp);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}