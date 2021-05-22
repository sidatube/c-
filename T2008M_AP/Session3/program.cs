using System;

namespace T2008M_AP.Session3
{
    public class program
    {
        public static void Main(string[] args)
        {
            product p = new product();
            p.Name = "ABC";
            p.Price = 1000;
            p.gallery.Add("img1");
            p.gallery.Add("img3");
            p.gallery.Add("img4");
         
            p[1] = "img5";
          
            for (int i = 0; i < p.gallery.Count; i++)
            {
                Console.WriteLine(p[i]); //get
            }
            
        }
    }
}