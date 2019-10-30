namespace MVCEngiBeering.Classes
{
    public class CntrlCmd
    {
        public int cntrlCommandValue;
        public int machSpeedValue;
        public int batchID;
        public int productID;
        public int amount;

        public CntrlCmd(int cntrlCommandValue, int machSpeedValue, int productID, int amount, int batchId)
        {
            this.cntrlCommandValue = cntrlCommandValue;
            this.machSpeedValue = machSpeedValue;
            this.productID = productID;
            this.amount = amount;
            this.batchID = batchId;
        }
    }
}