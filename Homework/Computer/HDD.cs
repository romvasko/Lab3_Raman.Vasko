using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Computer {
    internal class HDD {
        public string HddTitle { get; set; }
        public string HddDensity { get; set; }
        public string HddType { get; set; }
        public HDD() : this("unknown", "unknown","unknown") { }
        public HDD(string hddTitle, string hddDensity, string hddType) {
            HddTitle = hddTitle;
            HddDensity = hddDensity;
            HddType = hddType;
        }
        public override string ToString() {
            return $"HDD Title: {HddTitle}\nHDD Density: {HddDensity}\nHDD Type {HddType}\n";
        }
    }
}
