using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CArt
{
    public class Cart
    {
        public readonly List<CartItem> _listCartItem = new List<CartItem>();

        public List<CartItem> GetCart()
        {
            return _listCartItem.Select(item => new CartItem(item.Product, item.Quantity)).ToList();
        }

        public void AddToCart(CartItem cartItem)
        {
            bool update_status = false;
            foreach (var item in _listCartItem)
            {
                if (item.Product.Name == cartItem.Product.Name && item.Product.Price == item.Product.Price)
                {
                    item.Quantity = cartItem.Quantity;
                    update_status = true;
                }

            }

            if (update_status == false)
            {
                _listCartItem.Add(cartItem);
            }
        }

        public void RemoveFromCart(CartItem cartItem)
        {
            //bool remove_status = false;

            foreach (var item in _listCartItem)
            {

                if (item.Product.Name == cartItem.Product.Name && item.Product.Price == item.Product.Price)
                {
                    item.Quantity = cartItem.Quantity;
                    // remove_status = true;
                }
            }
        }


    }



}
