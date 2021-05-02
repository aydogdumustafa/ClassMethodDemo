using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CartManager
    {
        public static void AddToCart(Product product)
        {
            Console.WriteLine("{0} is added to cart for {1} $", product.Name, product.Price);
        }
    }
}
