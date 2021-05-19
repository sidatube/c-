using System;
using System.Collections;
using System.Collections.Generic;

namespace T2008M_AP.Lap.Lap1
{
    public class Product
    {
        public int id;
        public string name;
        public double price;
        public int qty;
        public string img;
        public ArrayList gallery = new ArrayList();
        public Product()
        {
        }

        public Product(int id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
          
        }

        public int GetId()
        {
            return id;

        }

        public void test()
        {
            gallery.Add("1a");
            gallery.Add("2a");
            gallery.Add("3a");
            gallery.Add("4a");
            gallery.Add("5a");
            gallery.Add("6a");
            gallery.Add("7a");
            gallery.Add("8a");
            gallery.Add("9a");
        }

        public void test2(string a)
        {
            if (gallery.Count<10)
            {
                gallery.Add(a);
                Console.WriteLine("Thêm thành công");
            }
            else
            {
                Console.WriteLine("Đã có 10 ảnh vui lòng xóa đi rồi thử lại");
            }
        }
        
        public void inanh()
        {
            int count = 0;
            foreach (var x in gallery)
            {
                Console.WriteLine(count+": "+x);
                count++;
            }
        }
        public void deleteimg(int x)
        {
            gallery.RemoveAt(x);
            Console.WriteLine("Xóa thành công");
        }
        public void oshirase()
        {
            if (qty==0)
            {
                Console.WriteLine("Hết hàng");
            }
            else
            {
                Console.WriteLine("Số lượng: "+qty);
            }
        }

        public void xoaanh()
        {
            Console.WriteLine("Bạn muốn xóa ảnh nào?");
            inanh();
            Console.WriteLine("Điền vị trí ảnh muốn xóa ");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            deleteimg(n);
            inanh();
        }
        public void getInfo()
        {
            Console.WriteLine("Toàn bộ thông tin:");
            Console.WriteLine("id: "+this.id+"-"+"name: "+this.name+"-"+"price: "+this.price+"-"+"qty: "+this.qty);
            Console.WriteLine("Ảnh của product");
          inanh();
           
        }
    }
}