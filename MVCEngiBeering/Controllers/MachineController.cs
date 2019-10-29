using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEngiBeering.Classes;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;
using MVCEngiBeering.ViewModels;
using Newtonsoft.Json;

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
        
        public void SendCntrlCmd(int cntrlCmdValue, int machSpeedValue, int productID, int amount, int id)
        {
            int batchId = 0;
            CntrlCmd cntrlCmd = new CntrlCmd(cntrlCmdValue, machSpeedValue, productID, amount, batchId);
            string output = JsonConvert.SerializeObject(cntrlCmd);
            Sender sender = new Sender("127.0.0.1");
            sender.send(output);
        }
    }
}