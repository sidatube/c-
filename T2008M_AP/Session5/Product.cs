using System;

namespace T2008M_AP.Session5
{
    public delegate void InStockProduct();
    public class Product
    {
        private int price;
        private bool inStock;
        private int qty;
        public event InStockProduct CheckStockProduct;
        public Product()
        {
            if (CheckStockProduct == null)
            {
                 CheckStockProduct += UpdateStock;
                 CheckStockProduct += ShowLog;
            }
               
        }

        public int Price
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
        public void UpdateStock()
        {
            if (Qty > 0)
            {
                InStock = true;
            }
            else
            {
                InStock = false;
            }
        }

        public void ShowLog()
        {
            if(InStock)
                Console.WriteLine("Hang con san");
        }

        public bool ChangePrice(int newPrice)
        {
            Price = newPrice;
            CheckStockProduct(); // phat ra event khi thay doi gia tien sp
            return true;
        }
        
        public bool ChangeStock(int qty)
        {
            Qty += qty;
            CheckStockProduct(); // phat ra event khi thay doi so luong sp
            return true;
        }
    }
}