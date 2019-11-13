using System;
using System.Collections.Generic;
using MVCEngiBeering.Models;

namespace MVCEngiBeering.ViewModels
{
    public class BBMachineViewModel
    {
        public int id {get; set; }
        public Guid uniqueid { get; set; }
        public MachineStateViewModel currentstate { get; set; }
        public int currentspeed { get; set; }
        public int currentproduct { get; set; }
        public int currentamount { get; set; }
        
    }
}