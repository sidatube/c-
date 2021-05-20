using System.Collections.Generic;

namespace T2008M_AP.Lap.Lap2
{
    public class Fashion : Lap1.Product
    {
        public string color;
        public string size;

        public Fashion(int id, string name, double price, int qty, string img, string desc,  string color, string size) : base(id, name, price, qty, img, desc)
        {
            gallery = new List<string>();
            this.color = color;
            this.size = size;
        }

        public bool checkhang(string c,string s)
        {
            if (this.color.Equals(c) && color.Equals(s) && qty > 0)
                return true;
            return false;
        }
        
    }
}