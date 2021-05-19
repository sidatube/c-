using System;

namespace T2008M_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //  Console.WriteLine("Hello bitch");
            // Console.WriteLine("Nhap 1 chuoi");
            //      string s = Console.ReadLine();
            //      Console.WriteLine("s =" + s);
            //      Console.WriteLine("Nhap 1 so nguyen");
            //      int n;
            //       try
            //     {
            //         n = Convert.ToInt32(Console.ReadLine());
            //      }
            //      catch (Exception e)
            //       {
            //           Console.WriteLine(e);
            //            throw;
            //      }

            //        Console.WriteLine("So vua nhap" + n);
            //       if (checkPrime(n))
            //       {
            //           Console.WriteLine("n la snt");
            //       }
            //       else
            //       {
            //           Console.WriteLine("n ko phai snt");
            //       }

            Console.WriteLine("so gan nhat: "+daysodai(30));
            
            

        }

        public static bool checkPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i < n/2; i++)
            {
                if (n%i==0) return false;
            }
            return true;
        }

        public static int daysodai(int n)
        {
           
            int a = 0, b = 1, c = 1;
            while (b+c<n)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }
            
    }
}