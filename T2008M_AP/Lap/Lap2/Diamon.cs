using System.Collections.Generic;

namespace T2008M_AP.Lap.Lap2
{
    public class Diamon : Lap1.Product
    {
        public double cara;

        public Diamon(int id, string name, double price, int qty, string img, string desc, double cara) : base(id, name, price, qty, img, desc)
        {
            this.cara = cara;
               gallery = new List<string>();
        }

        public bool checka()
        {
            if (cara < 10)
                return true; 
            return false;
        }
    }
}