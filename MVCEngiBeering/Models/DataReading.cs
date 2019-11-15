using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using Microsoft.VisualBasic;

namespace MVCEngiBeering.Models
{
    public class DataReading
    {
        public int id { get; set; }
        [ForeignKey("id")]
        public Batch batchid { get; set; }
        public int type {get; set;}
        public DateTime time {get; set;}
        public float value {get; set;}
    }
}