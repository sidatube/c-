using System;

namespace T2008M_AP.Session2
{
    public class Cat : Animal
    {
        public string Name;
        
        public void Nyannyan()
        {
         base.sleep();   
        }public void Nyannyan(string n)
        {
         base.sleep();   
         Console.WriteLine(n);
        }public void Nyannyan(int n)
        {
         base.sleep();   
         Console.WriteLine(n);

        }public void Nyannyan(string msg, int n)
        {
         base.sleep();   
         Console.WriteLine(n+msg);

        }

        public override void sleep()
        {
         Console.WriteLine("Nyan nyan nyan nyan nyan");
        }

        public new void Eat()
        {
         
        }
    }
}