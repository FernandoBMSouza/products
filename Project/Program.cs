using System;
using System.Collections.Generic;
using System.Globalization;
using Project.Entities;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Product #{i} data: ");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();

                if(type == "c")
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
                else if(type == "u")
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
                else if(type == "i")
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    System.Console.WriteLine("Invalid");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {
                System.Console.WriteLine(product.PriceTag());
            }

        }
    }
}