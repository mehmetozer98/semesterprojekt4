namespace MVCEngiBeering.ViewModels
{
    public class BatchViewModel
    {
        public int id { get; set; }
        public BBMachineViewModel machine { get; set; }
        public ProductTypeViewModel producttype { get; set; }
        public int setamount { get; set; }
        public int setspeed { get; set; }
    }
}