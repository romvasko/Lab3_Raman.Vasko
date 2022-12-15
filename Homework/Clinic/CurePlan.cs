using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Clinic {
    internal class CurePlan {
        public int CureId { get; set; }
        public CurePlan() {

        }
        public CurePlan(int id) {
            CureId = id;
        }
    }
}
