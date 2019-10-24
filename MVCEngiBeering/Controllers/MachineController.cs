using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;

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

            BBMachine bbMachine = _mvcEngibeeringContext.machines.First();
            
            return View(bbMachine);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}