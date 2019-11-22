using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEngiBeering.Models
{
    public class BBMachine
    {
        public int id {get; set; }
        public Guid uniqueid { get; set; }
        [Column("currentstate"),ForeignKey("id")]
        public int currentstate { get; set; }
        public int currentspeed { get; set; }
        [Column("currentproduct"),ForeignKey("id")]
        public int currentproduct { get; set; }
        public int currentamount { get; set; }
        
        public MachineState MachineState { get; set; }
        public ProductType ProductType { get; set; }
        public List<Batch> Batches { get; set; }
        
    }
}
