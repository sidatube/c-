using System;
using System.Threading;

namespace T2008M_AP.Session5
{
    public class Program
    {
        public static void Main(string[] args)
            {
                // tao thread voi static func
                Thread t = new Thread(ShowMsg); // truyen function se chay khi luong moi khoi tao
                t.Start();// chuyen snag runnable
                // tao thread co tham so va non-static func
                Thread t2 = new Thread(new Program().SayHelle);
                t2.Start("T2008M");// chay ham khi co tham so truyen ngay luc start
                // tao thread voi anonymous func - dung delegate
                new Thread(delegate(Object obj) // co hoac ko co tham so obj
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Anonymous func");
                        try
                        {
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }).Start();
            }

            public static void ShowMsg()
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Hello world");
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                    }
                }
            }

            public  void SayHelle(Object obj) // chi co 1 tham so Object
            {
                string msg = (string) obj;
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(msg);
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                    }
                }
            }
    }
}