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
                    throw new InValidPrice("Not a valid Price");

                _price = value;
            }
        }

        public string Name { get; set; }
    }
}
