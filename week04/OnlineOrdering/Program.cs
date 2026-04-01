using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA customer)
        Address address1 = new Address("123 Main St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P100", 800, 1),
            new Product("Mouse", "P200", 20, 2)
        };

        Order order1 = new Order(customer1, products1);

        // Order 2 (International customer)
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P300", 600, 1),
            new Product("Headphones", "P400", 50, 3)
        };

        Order order2 = new Order(customer2, products2);

        // Display orders
        DisplayOrder(order1);
        Console.WriteLine("----------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost()}");
        Console.WriteLine();
    }
}