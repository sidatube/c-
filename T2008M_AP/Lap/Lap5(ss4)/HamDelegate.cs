using System;

namespace T2008M_AP.Lap
{
    public delegate void Nhapso(int a, int b);
    public class HamDelegate
    {
        public void Cong(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Tong 2 so la: " +c);
        }

        public void Tru(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Hieu 2 so: "+c);
        }

        public void Nhan(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Tich 2 so: "+ c);
        }

        public void Thuong(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Thuong 2 so la: "+c);
        }
    }
}