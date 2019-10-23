using System;
namespace MVCEngiBeering.Models
{
    public class BBMachine
    {
        public int chosencommand { get; set; }
        private int speed { get; set; }
        private int product { get; set; }
        private int batchId { get; set; }
        private int amount { get; set; }
        public BBMachine()
        {
        }
    }
}
