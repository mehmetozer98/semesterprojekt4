namespace MVCEngiBeering.Models
{
    public class Batch
    {
        public int id { get; set; }
        public BBMachine machine { get; set; }
        public ProductType producttype { get; set; }
        public int totalamount { get; set; }
        public int goodamount { get; set; }
        public int defectamount { get; set; }
    }
}