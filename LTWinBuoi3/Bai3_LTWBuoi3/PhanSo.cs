using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3_LTWBuoi3
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }
        public PhanSo() {
            this.tuSo = 0;
            this.mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo) {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public void Input() {
            Console.Write("Nhap tu so: ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauSo = int.Parse(Console.ReadLine());
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        static int gcd(int a, int b)
        {
            while (a!=b)
            {
                if (a<b)
                {
                    b = b - a;
                }
                else
                {
                    a = a - b;
                }
            }
            return a;
        }
        public void RutGon() {
            
            int UCLN = gcd(tuSo,mauSo);
            if (UCLN!=1)
            {
                tuSo /= UCLN;
                mauSo /= UCLN;
            }
        }
        public string Print() {
            RutGon();
            return tuSo + "/" + mauSo;
        }

    }
}
