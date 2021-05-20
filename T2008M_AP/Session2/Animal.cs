using System;

namespace T2008M_AP.Session2
{
    public abstract class Animal
    {
        public string kind;
        public void eat()
        {
            Console.WriteLine("Eat");
        }
        public virtual void sleep()
        {
            Console.WriteLine("sleep");

        }
        public abstract void Running(); // abstract method
    }
}