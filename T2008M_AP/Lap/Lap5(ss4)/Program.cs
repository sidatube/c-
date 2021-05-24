using System;

namespace T2008M_AP.Lap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HamDelegate s = new HamDelegate();
            Nhapso ns1 = new Nhapso(Truf);
            ns1(9, 7);
            Nhapso ns = new Nhapso(s.Cong);
            
            ns += s.Tru;
            ns += s.Nhan;
            ns += s.Thuong;
            ns(9, 6);
        }
        public static void Truf(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("hieu 2 so la: " +c);
        }
    }
}