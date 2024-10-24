using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // instantiation 

        Address address = new Address("123 Mason Avenue", "Los Angeles", "CA", "USA"); // address needs to be first, I guess
        Customer customer = new Customer("Jane Doe", address); // contains our new address object

        Product product1 = new Product("Large Dog Bed", "P123", 120.00, 1);
        Product product2 = new Product("Chunky Dog Collar", "P246", 32.00, 1);
        Product product3 = new Product("Ceramic Dog Bowl", "P754", 45.00, 2);
        Product product4 = new Product("Dog Harnesh and Leash", "P757", 155.00, 2);
        Product product5 = new Product("Puppy Chow 10KG", "P654", 25.00, 2);
        Product product6 = new Product("FleaBlock Chewable 3 Pack", "P332", 60.99, 2);
        Product product7 = new Product("Dog Toy Braided Rope", "P332", 24.99, 1);
        Product product8 = new Product("Lightweight Dog Collar", "P256", 22.00, 1);

        Order order1 = new Order(customer); // new order, with the customer object
        Order order2 = new Order(customer); // new order, with the customer object

        // add products to the first order

        order1.AddProduct(product1); // this method is from Order 
        order1.AddProduct(product6);
        order1.AddProduct(product8);
        order1.AddProduct(product4);

        // add products to the second order

        order2.AddProduct(product5); 
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product7);

        // Order 1

        // print packing label
        Console.WriteLine();
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackagingLabel()); // also from Order

        // print shipping label
        Console.WriteLine(order1.GetShippingLabel()); // from Order
        Console.WriteLine();

        // print Total Cost
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}"); 
        Console.WriteLine();

        // Order 2

        // print packing label
        Console.WriteLine();
        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackagingLabel()); // also from Order

        // print shipping label
        Console.WriteLine(order2.GetShippingLabel()); // from Order
        Console.WriteLine();

        // print Total Cost
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}"); 
        Console.WriteLine();
    }

}