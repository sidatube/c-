using System;
using System.Threading;

namespace T2008M_AP.Lap.Lap6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Timer);
            t1.Start();
        }

        public static void Timer()
        {
            for (int i = 10; i >=0; i--)
            {
                for (int j = 59; j >=0; j--)
                {
                    if (i == 10)
                    {
                        j = 0;
                        Console.WriteLine(i+":0"+j);
                        try
                        {
                            Thread.Sleep(100);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    else
                    {
                        if (j>=10)
                        {
                            Console.WriteLine("0"+i+":"+j);
                            try
                            {
                                Thread.Sleep(100);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                        else
                        {
                            Console.WriteLine("0"+i+":0"+j);
                            try
                            {
                                Thread.Sleep(100);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                    
                }
            }
            Console.WriteLine("Kaboom...");
        }
    }
}