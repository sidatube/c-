using System;

namespace T2008M_AP.Session4
{
    public delegate void Showstring(string msg) ;// khai bao  1 delegate vaf 1 tham so
    public class DemoDelegate
    {
        public static Showstring publicDelegate = new Showstring(Showmsg);

        public static void Main(string[] args)
        {
            Showstring ss = new Showstring(Showmsg);// truyen ten ham co dang khai bao nhu delegate
            ss("ss");
            Showstring ss2 = new Showstring(new DemoDelegate().ShowInfo); //voiws ham non-static;
            // ss2("Nguyen van An");
            // nếu cùng truyền vào 1 chuỗi
            // ss("mai văn nam");
            // ss2("mai văn nam");
            // ShowString ss3 = new ShowString(ShowMessage);
            publicDelegate += new DemoDelegate().ShowInfo;// napj thêm hàm vào danh sách quản lý của delegate
            // ss3("Mai văn nam");
            DemoDelegate2 dd2 = new DemoDelegate2();
            publicDelegate("Mai An Tiem");
        }
        public static void Showmsg(string s)
        {
            Console.WriteLine(s);
        }  
        public void ShowInfo(string s)
        {
            Console.WriteLine(s);
        }
    }
}