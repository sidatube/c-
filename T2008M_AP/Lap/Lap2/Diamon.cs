namespace T2008M_AP.Lap.Lap2
{
    public class Diamon : Lap1.Product
    {
        public float cara;

        public Diamon(int id, string name, double price, int qty, float cara) : base(id, name, price, qty)
        {
            this.cara = cara;
        }

        public void checkhang()
        {
            
        }
    }
}