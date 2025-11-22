using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Customer customerOne = new Customer("Joshua", "Obodo", new Address("21 Kingsley Ave.", "Lekki-Ajah", "Lagos", "Nigeria"));
        Customer customerTwo = new Customer("Micheal", "Smith", new Address("1 Dave Str.", "Courtney's Town", "Texas", "USA"));
        Order orderOne = new Order(customerOne);
        Order orderTwo = new Order(customerTwo, new List<Product>()
        {
            new Product("Samsung Galaxy S24 Ultra", 319.25),
            new Product("Gucci Polo", 15.71, 6),
            new Product("Dried Vegetables", 7.80, 2)
        });

        orderOne.AddNewProduct(new Product("Apple Juice", 5.70));
        orderOne.AddNewProduct(new Product("Ultra Shoes", 32.90));
        orderOne.AddNewProduct(new Product("SuperCool Fan", 171.23, 2));
        orderOne.AddNewProduct(new Product("Grinded Rice", 50.71, 3));

        Console.WriteLine(orderOne.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderOne.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(orderTwo.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderTwo.GetShippingLabel());
    }
}