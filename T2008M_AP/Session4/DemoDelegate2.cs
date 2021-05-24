using System;

namespace T2008M_AP.Session4
{
    public class DemoDelegate2
    {
        
        public DemoDelegate2()
        {
      //      DemoDelegate.publicDelegate += ShowName;
        }

        public static void ShowName(string msg)
        {
            Console.WriteLine("Name: "+msg);
        }
    }
}