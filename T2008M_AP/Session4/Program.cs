using System;

namespace T2008M_AP.Session4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 15;
                x++;
                int z = x / y;
                Console.WriteLine("z=: "+z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}