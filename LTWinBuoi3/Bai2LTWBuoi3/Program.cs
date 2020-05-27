using System;

namespace Bai2LTWBuoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc dathuc1 = new DaThuc(4);
            dathuc1.KhoiTaoDaThuc();
            dathuc1.Print();
            Console.WriteLine("Nhap gia tri x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri cua da thuc tai x={0} la: {1}", x,dathuc1.tinhDaThuc(x));
            Console.ReadLine();
        }
    }
}
