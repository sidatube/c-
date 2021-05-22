namespace T2008M_AP.Lap.Lap4
{
    public abstract class Hoadondien
    {
        private int id;
        private string name;
        private string date;
        private string dategetbill;
        private int soluong;
        private decimal thanhtien;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public string Dategetbill
        {
            get => dategetbill;
            set => dategetbill = value;
        }

        public int Soluong
        {
            get => soluong;
            set => soluong = value;
        }
        
        public decimal Thanhtien
        {
            get => thanhtien;
            set => thanhtien = value;
        }

        protected Hoadondien()
        {
        }

        protected Hoadondien(int id, string name, string date, string dategetbill, int soluong)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.dategetbill = dategetbill;
            this.soluong = soluong;
           
        }

        public abstract decimal showbill();
       



    }
}