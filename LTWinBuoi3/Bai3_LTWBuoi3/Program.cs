using System;

namespace Bai3_LTWBuoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            MangPhanSo mangPS = new MangPhanSo(3);
            mangPS.KhoiTaoMangPhanSo();
            Console.Write("Ket qua cong tat ca cac phan so la: "+ mangPS.TinhTongPS());
        }
    }
}
