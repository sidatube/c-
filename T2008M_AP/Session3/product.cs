using System.Collections.Generic;

namespace T2008M_AP.Session3
{
    public class product
    {
        private string name;
        private decimal price;
        public List<string> gallery = new List<string>();
        //indexer
        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value; }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            } 
        }

        public List<string> Gallery
        {
            get => gallery;
          
        }
    }
}