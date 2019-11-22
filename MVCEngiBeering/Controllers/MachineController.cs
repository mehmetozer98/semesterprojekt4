using System;
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
            BBMachine machine = _mvcEngibeeringContext.machines.Include(m => m.currentstate).Include(m => m.currentproduct).Single(m => m.id == id);
            
            BBMachineViewModel temp = new BBMachineViewModel
            {
                currentamount = machine.currentamount,
                currentproduct = new ProductTypeViewModel
                {
                    id = machine.ProductType.id,
                    name = machine.ProductType.name
                },
                currentspeed = machine.currentspeed,
                currentstate =  new MachineStateViewModel
                {
                    id = machine.MachineState.id,
                    name = machine.MachineState.name
                },
                id = machine.id,
                uniqueid = machine.uniqueid
            };


            return View(temp);
        }
        
        [HttpPost]
        public IActionResult SendCntrlCmd(int cntrlCmdValue, int machSpeedValue, int productID, int amount, int id)
        {
            int batchId = 0;
            if (cntrlCmdValue == 2)
            {
                Console.WriteLine(_mvcEngibeeringContext.batches.Max(b => b.id));
                batchId = _mvcEngibeeringContext.batches.Max(b => b.id) + 1;
                
            }

            
            CntrlCmd cntrlCmd = new CntrlCmd(cntrlCmdValue, machSpeedValue, productID, amount, batchId);
            string output = JsonConvert.SerializeObject(cntrlCmd);
            Sender sender = new Sender("10.126.76.251");
            sender.send(output);
            return Redirect("get/" + id);
        }
    }
}