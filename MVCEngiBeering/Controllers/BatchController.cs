﻿using System;
using System.Collections.Generic;
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
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("json objected converted");
            DataReading temp = new DataReading();
            temp.time = data.time;
            temp.type = data.type;
            temp.value = data.value;
            temp.batchid = _mvcEngibeeringContext.batches.Find(data.batchid);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("adding object");
            _mvcEngibeeringContext.datareadings.Add(temp);
            _mvcEngibeeringContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddBatch(string json)
        {
            Batch data = JsonConvert.DeserializeObject<Batch>(json);
            _mvcEngibeeringContext.batches.Add(data);
            _mvcEngibeeringContext.SaveChanges();
            return Ok();
        }
    }
}