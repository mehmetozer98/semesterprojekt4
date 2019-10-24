using System;

namespace MVCEngiBeering.Models
{
    public class BBMachine
    {
        public int id {get; set; }
        public Guid uniqueid { get; set; }
        public int currentstate { get; set; }
        public int currentspeed { get; set; }
        public int currentproduct { get; set; }
        public int currentamount { get; set; }

        public BBMachine()
        {
        }
    }
}
