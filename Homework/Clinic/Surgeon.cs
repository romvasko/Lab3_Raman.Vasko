﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Homework.Clinic {
    internal class Surgeon : Doctor {
        public override string Cure() {
            return "Surgeon is healing";
        }
    }
}
