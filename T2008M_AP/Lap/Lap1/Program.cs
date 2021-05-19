namespace T2008M_AP.Lap.Lap1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product(1,"xzy",8000,3);
            p.test();
            p.test2("ba");
            p.test2("ba2");
            p.xoaanh();
            p.getInfo();
        }
    }
}