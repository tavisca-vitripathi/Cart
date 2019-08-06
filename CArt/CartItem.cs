using System;
using System.Collections.Generic;
using System.Text;

namespace CArt
{
   public class CartItem
    {
        public readonly Product _Product;

        public  int _Quantity { get; set; }


        public CartItem(Product product, int quantity)
        {
            this._Product = product;
            this._Quantity = quantity;
        }


        public int GetPrice()
        {
            return this._Quantity*_Product.Price;
        }




    }
}
