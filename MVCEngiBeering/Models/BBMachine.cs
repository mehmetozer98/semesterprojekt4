using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEngiBeering.Models
{
    public class BBMachine
    {
        public int id {get; set; }
        public Guid uniqueid { get; set; }
        [Column("currentstate"),ForeignKey("id")]
        public MachineState currentstate { get; set; }
        public int currentspeed { get; set; }
        public int currentproduct { get; set; }
        public int currentamount { get; set; }

        public BBMachine()
        {
        }
    }
}
