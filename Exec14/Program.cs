using Exec14.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exec14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else
                {
                    if (type == 'i')
                    {
                        Console.Write("Customs fee: ");
                        double cf = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, cf));
                    }
                    else
                    {
                        Console.Write("Manufacture date(DD/MM/YYYY): ");
                        DateTime md = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, md));
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
