namespace T2008M_AP.Lap.Lap4
{
    public class NguoiVN : Hoadondien
    {
        string doituong;

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }

        public NguoiVN(int id, string name, string date, string dategetbill, int soluong, string doituong) : base(id, name, date, dategetbill, soluong)
        {
            this.doituong = doituong;
        }

        public override decimal showbill()
        {
            if (Soluong<=50)
            {
                Thanhtien = Soluong * 1000;
            }
            else if (Soluong<=100)
            {
                Thanhtien = 50 * 1000 + (Soluong-50)*1200;
            }
            else if (Soluong<=200)
            {
                Thanhtien = 50 * 1000 + 50*1200+(Soluong-100)*1500;
            }
            else if (Soluong > 200)
            {
                Thanhtien = 50 * 1000 + 50*1200 + 100*1500 +(Soluong-200)*2000;
            }

            return Thanhtien;
        }
        
    }
}