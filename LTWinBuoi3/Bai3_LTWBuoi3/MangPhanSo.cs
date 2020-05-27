using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3_LTWBuoi3
{
    class MangPhanSo
    {
        public PhanSo [] mangPhanSo;
        public int soLuongPhanSo = 1;
        public PhanSo this[int i] {
            get { return mangPhanSo[i]; }
            set { mangPhanSo[i] = value; }
        }
        public MangPhanSo(int soLuongPhanSo) {
            mangPhanSo = new PhanSo[soLuongPhanSo];
            this.soLuongPhanSo = soLuongPhanSo;

            for (int i = 0; i < this.soLuongPhanSo; i++)
            {
                this[i] = new PhanSo(0,1);
            }
        }
        public void KhoiTaoMangPhanSo() {
            for (int i = 0; i < this.soLuongPhanSo; i++)
            {
                PhanSo phanso = this[i];
                Console.Write("Nhap tu so phan so" + i+": ");
                this[i].TuSo = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so phan so" + i + ": ");
                this[i].MauSo = int.Parse(Console.ReadLine());

            }
        }
        public string TinhTongPS()
        {
            PhanSo kq = new PhanSo();
            for (int i = 0; i < this.soLuongPhanSo; i++)
            {
                kq += this[i];
            }
            return kq.Print();
        }
    }
}
