using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Chocolate";
            product1.Price = 3.12;

            Product product2 = new Product();
            product2.Name = "Milk";
            product2.Price = 1.34;

            Product product3 = new Product();
            product3.Name = "Bread";
            product3.Price = 0.46;

            ProductManager productManager = new ProductManager();

            productManager.AddToCart(product1);
            productManager.AddToCart(product2);
            productManager.AddToCart(product3);
        }
    }
}
