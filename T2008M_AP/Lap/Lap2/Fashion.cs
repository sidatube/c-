namespace T2008M_AP.Lap.Lap2
{
    public class Fashion : Lap1.Product
    {
        public string color;
        public string size;

        public Fashion(int id, string name, double price, int qty, string color, string size) : base(id, name, price, qty)
        {
            this.color = color;
            this.size = size;
        }

        public void checkhang(string size,string color)
        {
            
        }
        
    }
}