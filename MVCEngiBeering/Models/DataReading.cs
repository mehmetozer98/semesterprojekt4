using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using Microsoft.VisualBasic;

namespace MVCEngiBeering.Models
{
    public class DataReading
    {
        public int id { get; set; }
        public int batchID { get; set; }
        public int type {get; set;}
        public NpgsqlTypes.NpgsqlDateTime time {get; set;}
        public float value {get; set;}
    }
}