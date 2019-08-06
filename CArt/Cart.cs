using System;
using System.Collections.Generic;
using System.Text;

namespace CArt
{
   public class Cart
    {
        private List<CartItem> _listCartItem = new  List<CartItem>() ;

        public List<CartItem> GetCart()
        {
            return _listCartItem;
        }

        public void AddToCart(CartItem cartItem)
        {
            bool update_status = false;
            foreach ( var item in _listCartItem)
            {
                if(item._Product.Name == cartItem._Product.Name && item._Product.Price==item._Product.Price)
                {
                    item._Quantity = cartItem._Quantity;
                    update_status = true;
                }

            }
             
            if(update_status== false)
            {
                _listCartItem.Add(cartItem);
            }
        }

        public void RemoveFromCart(CartItem cartItem)
        {
            //bool remove_status = false;
            
                foreach (var item in _listCartItem)
                {

                    if (item._Product.Name == cartItem._Product.Name && item._Product.Price == item._Product.Price)
                    {
                        item._Quantity = cartItem._Quantity;
                       // remove_status = true;
                    }
                }  
        }


    }



}
