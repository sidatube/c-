using System;
using System.Collections.Generic;
using T2008M_AP.Lap.Lap1;

namespace T2008M_AP.Lap.Lap3
{
    public delegate void InStockProduct();
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private bool inStock;

        public List<Product> Productlist;
        public event InStockProduct CheckStockProduct;
        public event InStockProduct CheckQty;
        private string city;
        private string country;

        public Cart()
        {
          Productlist = new List<Product>();
          if (CheckStockProduct==null)
          {
              CheckStockProduct += showlog;
          }

          if (CheckQty==null)
          {
              CheckQty += updatecart;
          }
        }
        
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public bool InStock
        {
            get => inStock;
            set => inStock = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public void showlog()
        {
            Console.WriteLine("Sản phẩm đã được thêm ");
        }
        public void updatecart()
        {
            if (InStock)
            {
                Console.WriteLine("Đã thêm sản phẩm");
            }
            else
            {
                Console.WriteLine("Đã xóa sản phẩm");
            }
            
        }
        
        public void addPro(Product a)
        {
            if (a.checkqty())
            {
                Productlist.Add(a);
                a.Qty = a.Qty - 1;
                grandTotal = grandTotal + a.Price;
                InStock = true;
                CheckStockProduct();
                return ;
            }
            Console.WriteLine("Fail!!");

        }
        public void removePro(Product a)
        {
            Productlist.Remove(a);
            a.Qty = a.Qty + 1;
            grandTotal = grandTotal - a.Price;
            InStock = false;
            CheckQty();
        }

        public void show()
        {
            Console.WriteLine("Show cart");
            foreach (var x in Productlist)
            {
                Console.WriteLine(x.Name+" - "+x.Price);
            }
        }
        public void total()
        {
            
            if (country!= "Vietnam")
            {
              
                grandTotal=grandTotal*(100+5)/100;
            }
            else if (city=="HN"||city=="HCM")
            {
                grandTotal=grandTotal*(100+1)/100;
            }else
            {
                grandTotal=grandTotal*(100+2)/100;
            }
            Console.WriteLine(grandTotal);
        }
        
    }
}