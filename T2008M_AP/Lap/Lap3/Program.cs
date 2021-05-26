using T2008M_AP.Lap.Lap1;
using T2008M_AP.Lap.Lap2;

namespace T2008M_AP.Lap.Lap3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Diamon(1, "Diamon 2C", 5000, 2, "link1", "desc", 2.0);
            Product p2 = new Fashion(1, "jeans", 50000, 10, "img1", "desc", "black", "XL");
            Product p3 = new Product(1, "Toy", 100000, 10, "img1", "desc");

            Cart c = new Cart();
            c.Customer = "bbb";
            c.City = "Hn";
            c.Country = "Vietnam";
            c.addPro(p1);
            c.addPro(p1);
            c.addPro(p2);
            c.addPro(p2);
            c.show();
            c.total();
            c.addPro(p1);
            c.removePro(p2);
            c.addPro(p3);
            c.show();
            c.total();
            
        }
    }
}