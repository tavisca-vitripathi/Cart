using System;
using System.Collections.Generic;
using System.Text;

namespace CArt
{
   public class CartItem
    {
        public readonly Product Product;

        public  int Quantity { get; set; }


        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }


        public int Price
        {
            get
            {
                return this.Quantity * Product.Price;
            }
        }




    }
}
