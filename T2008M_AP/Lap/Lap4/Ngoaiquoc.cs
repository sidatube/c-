namespace T2008M_AP.Lap.Lap4
{
    public class Ngoaiquoc : Hoadondien
    {
        private string quoctich;

        public string Quoctich
        {
            get => quoctich;
            set => quoctich = value;
        }

        public Ngoaiquoc(int id, string name, string date, string dategetbill, int soluong, string quoctich) : base(id, name, date, dategetbill, soluong)
        {
            this.quoctich = quoctich;
        }

        public override decimal showbill()
        {
           return Thanhtien = Soluong * 2000;
        }
    }
}