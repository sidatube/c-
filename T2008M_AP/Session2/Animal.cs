using System;

namespace T2008M_AP.Session2
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eat");
        }
        public virtual void sleep()
        {
            Console.WriteLine("sleep");

        }
    }
}