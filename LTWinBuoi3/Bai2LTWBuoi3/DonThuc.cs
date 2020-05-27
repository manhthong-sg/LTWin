using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2LTWBuoi3
{
    public class DonThuc
    {
        //don thuc: a*x^n;
        public double hesoA;
        public int soMuN;
        public DonThuc() { hesoA = 1; soMuN = 0; }
        public DonThuc(double a, int n)
        {
            this.hesoA = a;
            this.soMuN = n;
        }
        public string Print() {
            return this.hesoA + "*x^" + this.soMuN;
        }
    }
}
