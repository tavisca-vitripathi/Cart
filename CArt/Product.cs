using System;
using System.Collections.Generic;
using System.Text;

namespace CArt
{
    public class Product
    {
        private int _price;
        public int Price {
            get {

                return _price;
            }

            set
            {
                if (value < 0)
                    throw new InValidPrice("MyProperty has a maximum length of 100.");

                _price = value;
            }
        }

        public string Name { get; set; }
    }
}
