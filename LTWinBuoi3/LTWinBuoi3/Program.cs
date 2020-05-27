using System;

namespace LTWinBuoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu mang1 = new Mang1Chieu(5);
            Console.WriteLine(mang1.length);
            //----------------
            for (int i = 0; i < mang1.length; i++)
            {
                Console.Write("Nhap gia tri phan tu {0}: ", i);
                mang1[i]= int.Parse(Console.ReadLine());
            }
            mang1.Print();
            mang1.PrintEven();
            Console.ReadKey();
        }
    }
}
