using System;
using System.Collections.Generic;
using System.Text;

namespace LTWinBuoi3
{
    class Mang1Chieu
    {
        private int[] arr = new int[100];

        public Mang1Chieu() { }
        public Mang1Chieu(int soPhanTu) {
            this.arr = new int[soPhanTu];
        }
        public int length
        {
            get { return this.arr.Length; }
        }
        public int this[int i]
        {
            get { return this.arr[i]; }
            set { this.arr[i] = value; }

        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void PrintEven()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this[i]%2==0)
                {
                    Console.Write(this[i] + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
