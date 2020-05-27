using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bai2LTWBuoi3
{
    class DaThuc
    {
        // f(x)=a0*x^0+a1*x^1+...+an*x^n
        private DonThuc[] mangDonThuc;
        private int soLuongDonThuc = 1;
        public DaThuc()
        {
            mangDonThuc = new DonThuc[1];
            mangDonThuc[0] = new DonThuc();
        }
        public DaThuc(int soLuongDonThuc) {
            mangDonThuc = new DonThuc[soLuongDonThuc];
            this.soLuongDonThuc = soLuongDonThuc;
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                this[i] = new DonThuc(1, i);
            }
        }
        //operator[]
        public DonThuc this[int i] {
            get { return mangDonThuc[i]; }
            set { mangDonThuc[i] = value; }
        }
        public void KhoiTaoDaThuc()
        {
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                DonThuc mDonThuc = this[i];
                mDonThuc.soMuN = i;
                Console.Write("Nhap gia tri he so cua don thuc thu " + i + " cua da thuc: ");
                mDonThuc.hesoA = double.Parse(Console.ReadLine());
            }
        }
        public void Print() {
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                Console.Write(this[i].Print());
                if (i!=this.soLuongDonThuc-1)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }
        public double tinhDaThuc(double x)
        {
            double sum = 0;
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                sum += this[i].hesoA * Math.Pow(x, i);
            }
            return sum;
        }
    }
}
