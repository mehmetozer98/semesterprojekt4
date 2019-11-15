namespace MVCEngiBeering.Models
{
    public class Batch
    {
        public int id { get; set; }
        public BBMachine machine { get; set; }
        public ProductType producttype { get; set; }
        public int setamount { get; set; }
        public int setspeed { get; set; }
    }
}