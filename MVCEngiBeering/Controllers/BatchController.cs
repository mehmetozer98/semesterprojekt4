using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using MVCEngiBeering.Classes;
using MVCEngiBeering.Data;
using MVCEngiBeering.Models;
using MVCEngiBeering.ViewModels;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCEngiBeering.Controllers
{
    public class BatchController : Controller
    {
        private MvcEngibeeringContext _mvcEngibeeringContext;

        public BatchController(MvcEngibeeringContext mvcEngibeeringContext)
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
            
            DataReadingViewModel data = JsonConvert.DeserializeObject<DataReadingViewModel>(json);
            Console.WriteLine("id: " + data.batchid);
            Console.WriteLine("id: " + data.type);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("json objected converted");
            DataReading temp = new DataReading();
            //temp.time = DateTime.ParseExact(data.time,"dd-MM-yyyy hh:mm:ss",CultureInfo.InvariantCulture);
            temp.time = DateTime.Now;
            temp.type = data.type;
            temp.value = data.value;
            //temp.batchid = _mvcEngibeeringContext.batches.Find(data.batchid);
            temp.batchid = _mvcEngibeeringContext.batches.Single(b => b.id.Equals(data.batchid));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("id: " + temp.batchid.id);
            Console.WriteLine("adding object");
            _mvcEngibeeringContext.Add(temp);
            _mvcEngibeeringContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddBatch(string json)
        {
            BatchViewModel data = JsonConvert.DeserializeObject<BatchViewModel>(json);
            Batch batch = new Batch();
            batch.id = data.id;
            batch.machine = _mvcEngibeeringContext.machines.Find(data.machine);
            batch.producttype = _mvcEngibeeringContext.producttypes.Find(data.producttype);
            batch.setamount = data.setamount;
            batch.setspeed = data.setspeed;
            _mvcEngibeeringContext.batches.Add(batch);
            batch.id = data.id;
            _mvcEngibeeringContext.SaveChanges();
            return Ok();
        }
    }
}