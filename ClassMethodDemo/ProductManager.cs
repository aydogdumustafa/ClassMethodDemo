using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ProductManager
    {
        public void AddToCart(Product product)
        {
            Console.WriteLine("{0} is added to cart for {1} $", product.Name, product.Price);
        }
    }
}
