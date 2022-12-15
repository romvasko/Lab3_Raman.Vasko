using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Computer {
    internal class RAM {
        public string RamTitle { get; set; }
        public string RamDensity { get; set; }
        public RAM() : this("unknown", "unknown") { }
        public RAM(string ramTitle, string ramDensity) {
            RamTitle = ramTitle;
            RamDensity = ramDensity;
        }
        public override string ToString() 
        {
            return $"RAM Title: {RamTitle}\nRAM Density: {RamDensity}\n";
        }
    }
}
