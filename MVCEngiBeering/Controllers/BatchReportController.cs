using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using MVCEngiBeering.Classes;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCEngiBeering.Controllers
{
    public class BatchReportController : Controller
    {
        private MvcEngibeeringContext _mvcEngibeeringContext;

        public BatchReportController(MvcEngibeeringContext mvcEngibeeringContext)
        {
            _mvcEngibeeringContext = mvcEngibeeringContext;
        } 
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReading(string json)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("received json");
            Console.WriteLine("json: " + json);
            
            DataReceiving data = JsonConvert.DeserializeObject<DataReceiving>(json);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("json objected converted");
            DataReading temp = new DataReading();
            temp.time = Convert.ToDateTime(data.TimeStamp);
            temp.type = data.Type;
            temp.value = data.Value;
            temp.batchid = _mvcEngibeeringContext.batches.Find(data.BatchId);
            BBMachine machine = _mvcEngibeeringContext.machines.Find(Convert.ToInt32(data.MachineId));
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("adding object");
            _mvcEngibeeringContext.datareadings.Add(temp);
            _mvcEngibeeringContext.SaveChanges();
            return Ok();
        }

        private int getNextBatchId()
        {
            return _mvcEngibeeringContext.batches.Max().id + 1;
        }
    }
}