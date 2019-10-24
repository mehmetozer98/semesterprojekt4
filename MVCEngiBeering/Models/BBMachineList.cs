using System.Collections.Generic;

namespace MVCEngiBeering.Models
{
    public class BBMachineList
    {
        public List<BBMachine> machineList { get; set; }

        public BBMachineList()
        {
            machineList = new List<BBMachine>();
            machineList.Add(new BBMachine());
            machineList.Add(new BBMachine());
            machineList[0].currentstate = 4;
            machineList[1].currentstate = 1;
        }
    }
}
