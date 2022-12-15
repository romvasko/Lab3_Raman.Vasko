using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Clinic {
    internal class Patient {
        CurePlan plan;
        Doctor doc;
        public Patient(CurePlan plan) 
        {
            this.plan = plan;
            SetDoctor();
        }
        private int SetDoctor() {
            if (plan.CureId == 1) {
                doc = new Surgeon();
                return 0;
            }
            if (plan.CureId == 2) {
                doc = new Dentist();
                return 0;
            }
            doc = new Therapist();
            return 0;
        }
        public string GetCure() {
            return doc.Cure();        
        }
    }
}
