using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Computer {
    internal class Computer {
        public string ComputerCost { get; set; }
        public string ComputerName { get; set; }
        RAM ram;
        HDD hdd;
        public Computer(int computerCost, string computerName) {
            ComputerCost = String.Format("{0:c}", computerCost);
            ComputerName = computerName;
            ram = new RAM();
            hdd = new HDD();
        }
        public Computer(int computerCost, string computerName, RAM ram, HDD hdd) {
            ComputerCost = String.Format("{0:c}", computerCost);
            ComputerName = computerName;
            this.ram = ram;
            this.hdd = hdd;
        }
        public override string ToString() {
            return $"Computer Cost: {ComputerCost}\nComputer Name: {ComputerName}\n{ram}{hdd}";
        }
    }
}
