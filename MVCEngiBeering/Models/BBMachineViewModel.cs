using System;
using System.Collections.Generic;

namespace MVCEngiBeering.Models
{
    public class BBMachineViewModel
    {
        public List<BBMachine> Machines { get; set; }
        public int id {get; set; }
        public Guid uniqueid { get; set; }
        public int currentstate { get; set; }
        public int currentspeed { get; set; }
        public int currentproduct { get; set; }
        public int currentamount { get; set; }
        
    }
}