using CArt;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Product product = new Product();
            product.Name = "apples";
            product.Price = 300;
            CartItem cartItem = new CartItem(product,20);
            Cart cart = new Cart();
            cart.AddToCart(cartItem);
            List<CartItem> list = new List<CartItem>();
            list.Add(cartItem);
            Assert.Equal(list,cart.GetCart());
        }
         [Fact]
        public void RemoveTest()
        {
            Product product = new Product();
            product.Name = "apples";
            product.Price = 300;
            //==============
            Product product1 = new Product();
            product1.Name = "Mango";
            product1.Price = 300;
            //==========
            CartItem cartItem = new CartItem(product, 20);
            CartItem cartItem2 = new CartItem(product1, 20);
            Cart cart = new Cart();
            cart.AddToCart(cartItem);
            cart.AddToCart(cartItem2);
            cart.RemoveFromCart(cartItem2);
            List<CartItem> list = new List<CartItem>();
            list.Add(cartItem);

        }

        [Fact]
        public void GetPriceTest()
        {
            Product product = new Product();
            product.Name = "apples";
            product.Price = 300;
            CartItem cartItem = new CartItem(product, 20);
            Assert.Equal(6000, cartItem.GetPrice());
        }









    }
}
