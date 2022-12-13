using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes {
    internal class Phone {
        private int number { get; set; }
        private string model { get; set; }
        private int weight { get; set; }
        public Phone(int num, string mod, int wei) 
        {
            number = num;
            model = mod;
            weight = wei;
        }
        public override string ToString() {
            return number.ToString() + " " + model.ToString() + " " + weight.ToString();
        }
        public string ReceiveCall(string name)
        {
            return name + " is calling";
        }
        public string ReceiveCall(string name, int num)
        {
            return name + " is calling " + num.ToString("+375 (44) ###-##-##");
        }
        public string GetNumber() {
            return number.ToString("+375 (44) ###-##-##");
        }
        public static string SendMessage(params int[] num) {
            StringBuilder sb = new StringBuilder();
            sb.Append("Phone numbers to send message:\n");
            foreach (int n in num) {
                sb.Append(n.ToString("+375 (44) ###-##-##\n"));
            }
            return sb.ToString();
        }

    }
}
