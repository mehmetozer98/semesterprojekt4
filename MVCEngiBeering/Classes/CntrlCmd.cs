namespace MVCEngiBeering.Classes
{
    public class CntrlCmd
    {
        private int cntrlCmdValue;
        private int machSpeedValue;
        private int batchID;
        private int productID;
        private int amount;

        public CntrlCmd(int cntrlCmdValue, int machSpeedValue, int productID, int amount, int batchId)
        {
            this.cntrlCmdValue = cntrlCmdValue;
            this.machSpeedValue = machSpeedValue;
            this.productID = productID;
            this.amount = amount;
            this.batchID = batchID;
        }
    }
}