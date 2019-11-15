using System;

namespace MVCEngiBeering.ViewModels
{
    public class DataReadingViewModel
    {
        public int id { get; set; }
        public BatchViewModel batchid { get; set; }
        public int type {get; set;}
        public DateTime time {get; set;}
        public float value {get; set;}
    }
}