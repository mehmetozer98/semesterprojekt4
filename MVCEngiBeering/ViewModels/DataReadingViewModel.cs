using System;

namespace MVCEngiBeering.ViewModels
{
    public class DataReadingViewModel
    {
        public int id { get; set; }
        public int batchid { get; set; }
        public int type {get; set;}
        public string time {get; set;}
        public float value {get; set;}
    }
}