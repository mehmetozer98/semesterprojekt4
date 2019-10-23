using System;
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
            machineList[0].chosencommand = 4;
            machineList[1].chosencommand = 1;
        }
    }
}
