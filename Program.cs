using System.Globalization;
using OrderApp.Entities;
using OrderApp.Entities.Enums;

namespace OrderApp;

class Program()
{
    static void Main()
    {
        Console.WriteLine("Enter client data:");

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Client client = new Client(name, email, birthDate);

        Console.WriteLine("Enter order data: ");

        Console.Write("Status: ");
        string os = Console.ReadLine();
        OrderStatus status = (OrderStatus)Enum.Parse(typeof (OrderStatus), os);
        
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("How many items to this order: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1;  i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");

            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(productName, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity, price, product);

            order.AddItem(orderItem);

        }

        Console.WriteLine();
        Console.WriteLine("ORDER SUMARY:");
        Console.WriteLine(order);

    }
}