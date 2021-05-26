using System;
using System.Collections;
using System.Collections.Generic;

namespace T2008M_AP.Lap.Lap1
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private bool inStock;
        private int qty;
        private string img;
        private string desc;
        public List<string> gallery;
        public Product()
        {
            gallery = new List<string>();
        }

        public Product(int id, string name, double price, int qty, string img, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.img = img;
            this.desc = desc;
            gallery = new List<string>();
        }

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

        public double Price
        {
            get => price;
            set => price = value;
        }

        public bool InStock
        {
            get => inStock;
            set => inStock = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Img
        {
            get => img;
            set => img = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
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

        public void themanh(string a)
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
        public void deleteimg(int img)
        {
            gallery.RemoveAt(img);
            Console.WriteLine("Xóa thành công");
        }
        public bool checkqty()
        {
            if (qty > 0)
                return true;
            return false;
        }
        public void UpdateStock()
        {
            if (qty > 0)
            {
                InStock = true;
            }
            else
            {
                InStock = false;
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