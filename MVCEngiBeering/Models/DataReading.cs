using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using Microsoft.VisualBasic;

namespace MVCEngiBeering.Models
{
    public class DataReading
    {
        public int id { get; set; }
        public int batchid { get; set; }
        public int type {get; set;}
        public DateTime time {get; set;}
        public float value {get; set;}
    }
}