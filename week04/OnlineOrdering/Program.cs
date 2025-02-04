using System;

class Program
{
    static void Main(string[] args)
    {
         // Create some sample products
        Product product1 = new Product("Laptop", 101, 1000.00, 1);
        Product product2 = new Product("Mouse", 102, 25.00, 2);

        // Create an address and customer
        Address address = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer = new Customer("John Doe", address)   ;

        // Create an order and add products to it
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display packing and shipping labels and total price
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}\n");

        // Another order with an international address
        Address internationalAddress = new Address("456 Elm St", "Townsville", "NSW", "Australia");
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(product1);

        // Display international order details
        Console.WriteLine(internationalOrder.GetPackingLabel());
        Console.WriteLine(internationalOrder.GetShippingLabel());
        Console.WriteLine($"Total Price: ${internationalOrder.CalculateTotalPrice():0.00}\n");
    }
}