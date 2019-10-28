using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            BBMachine machine = _mvcEngibeeringContext.machines.Include(m => m.currentstate).Single(m => m.id == id);
            
            BBMachineViewModel temp = new BBMachineViewModel
            {
                currentamount = machine.currentamount,
                currentproduct = machine.currentproduct,
                currentspeed = machine.currentspeed,
                currentstate =  new MachineStateViewModel
                {
                    id = machine.currentstate.id,
                    name = machine.currentstate.name
                },
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