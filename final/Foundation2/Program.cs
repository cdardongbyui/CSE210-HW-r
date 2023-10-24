using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order #1
        Address address1 = new Address("1st Street", "Guatemala", "Guatemala", "Guatemala");
        Customer customer1 = new Customer("Cristian Dardón", address1);
        List<Product> productsList1 = new List<Product>();

        Product product1Order1 = new Product("Laptop ASUS", "CA5000", 459.99, 1);
        Product product2Order1 = new Product("iPad", "IPA225", 325.50, 5);
        Product product3Order1 = new Product("Monitor DELL 27", "DELL2705", 199.99, 10);

        productsList1.Add(product1Order1);
        productsList1.Add(product2Order1);
        productsList1.Add(product3Order1);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // ###########################################################################################################################

        // Order #2
        Address address2 = new Address("123 St", "Arizona", "Texas", "USA");
        Customer customer2 = new Customer("Bill Gates", address2);
        List<Product> productsList2 = new List<Product>();

        Product product1Order2 = new Product("Microsoft Office 365", "MO365", 124.99, 3);
        Product product2Order2 = new Product("Windows Server", "WS100", 222.75, 2);
        Product product3Order2 = new Product("iPhone 15 ProMAX", "IPO15PM", 400.50, 1);

        productsList2.Add(product1Order2);
        productsList2.Add(product2Order2);
        productsList2.Add(product3Order2);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // ###########################################################################################################################

        // Order #3
        Address address3 = new Address("21 W 50 S", "Salt Lake", "UTAH", "USA");
        Customer customer3 = new Customer("Landon Donovan", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Tablet Samsung A7", "TSA7", 98.99, 2);
        Product p3002 = new Product("Pencil touch", "PEN100", 14.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
