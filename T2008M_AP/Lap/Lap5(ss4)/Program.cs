namespace T2008M_AP.Lap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HamDelegate s = new HamDelegate();
            Nhapso ns = new Nhapso(s.Cong);
            ns += s.Tru;
            ns += s.Nhan;
            ns += s.Thuong;
            ns(9, 6);
        }
    }
}