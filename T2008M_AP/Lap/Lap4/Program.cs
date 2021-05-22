using System;

namespace T2008M_AP.Lap.Lap4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Khachang list = new Khachang();
            NguoiVN v1 = new NguoiVN(1, "BCT","01/2019", "28/01/2019", 63, "Sinh hoạt");
            NguoiVN v12 = new NguoiVN(1, "BCT","02/2019","28/02/2019", 78, "Sinh hoạt");
            NguoiVN v2 = new NguoiVN(2, "Cty", "01/2019","28/01/2019", 500, "Sản xuất");
            NguoiVN v22 = new NguoiVN(2, "Cty","02/2019", "28/02/2019", 600, "Sản xuất");
            NguoiVN v3 = new NguoiVN(3, "TTT","01/2019", "28/01/2019", 78, "Kinh doanh");
            NguoiVN v32 = new NguoiVN(3, "TTT","02/2019", "28/02/2019", 79, "Kinh doanh");
            Ngoaiquoc n1 = new Ngoaiquoc(1, "John","01/2019", "28/01/2019", 90, "Anh");
            Ngoaiquoc n12 = new Ngoaiquoc(1, "John", "02/2019","28/02/2019", 110, "Anh");
            Ngoaiquoc n2 = new Ngoaiquoc(2, "Lucher","01/2019", "28/01/2019", 83, "Mỹ");
            Ngoaiquoc n22 = new Ngoaiquoc(2, "Lucher","02/2019", "28/02/2019", 93, "Mỹ");
            list.Khachhang.Add(v1);
            list.Khachhang.Add(v12);
            list.Khachhang.Add(v2);
            list.Khachhang.Add(v22);
            list.Khachhang.Add(v3);
            list.Khachhang.Add(v32);
            list.Khachhang.Add(n1);
            list.Khachhang.Add(n12);
            list.Khachhang.Add(n2);
            list.Khachhang.Add(n22);
            list.showAllBill();
            list.loc();
            list.TbttNQ();
            list.showbillT1();
            



        }
    }

    
}