using System;
using System.Runtime.Serialization;

namespace CArt
{
   
     public  class InValidPrice : Exception
    {
       
  
        public InValidPrice(string message) : base(message)
        {
            Console.WriteLine(message);
        }

      
    }
}