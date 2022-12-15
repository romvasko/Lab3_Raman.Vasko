using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.ATM {
    internal class ATM {
        public int Bill_10 { get; set; }
        public int Bill_20 { get; set; }
        public int Bill_100 { get; set; }
        public ATM(int bill_10,int bill_20,int bill_100) {
            Bill_10 = bill_10;
            Bill_20 = bill_20;
            Bill_100 = bill_100;
        }
        public override string ToString() {
            return $"In ATM now:\nbill 10: {Bill_10}\nbill 20: {Bill_20}\nbill 100: {Bill_100}\n";
        }
        private int[] SplitSum(int sum) {
            int[] result = new int[3];
            result[0] = sum / 100;
            sum %= 100;
            result[1] = sum / 20;
            sum %= 20;
            result[2] = sum / 10;
            sum %= 10;
            return result;
        }
        public string AddMoney(int sum) {
            int[] vs = SplitSum(sum);
            Bill_10 += vs[2];
            Bill_20 += vs[1];
            Bill_100 += vs[0];
            return $"Added to ATM: {sum}\nbill 10: {vs[2]}\nbill 20: {vs[1]}\nbill 100: {vs[0]}\n";
        }
        public string RemoveMoney(int sum) {
            int[] vs = SplitSum(sum);
            if (Bill_10 < vs[2] || Bill_20 < vs[1] || Bill_100 < vs[0]) {
                return "net deneg";
            }
            Bill_10 -= vs[2];
            Bill_20 -= vs[1];
            Bill_100 -= vs[0];
            return $"Removed From ATM: {sum}\nbill 10: {vs[2]}\nbill 20: {vs[1]}\nbill 100: {vs[0]}\n";
        }
    }
}
