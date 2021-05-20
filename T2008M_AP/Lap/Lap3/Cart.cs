using System;
using System.Collections.Generic;
using T2008M_AP.Lap.Lap1;

namespace T2008M_AP.Lap.Lap3
{
    public class Cart
    {
        public int id;
        public string customer;
        public double grandTotal;
        public List<Product> Productlist;
        public string city;
        public string country;

        public Cart()
        {
          Productlist = new List<Product>();
        }

        public bool addPro(Product a)
        {
            if (a.checkqty())
            {
                Productlist.Add(a);
                a.qty = a.qty - 1;
                grandTotal = grandTotal + a.price;
                return true;
            }
            Console.WriteLine("Fail!!");
            return false;


        } public void removePro(Product a)
        {
            Productlist.Remove(a);
            a.qty = a.qty + 1;
            grandTotal = grandTotal - a.price;
        }

        public void show()
        {
            Console.WriteLine("Show cart");
            foreach (var x in Productlist)
            {
                Console.WriteLine(x.name+" - "+x.price);
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