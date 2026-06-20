using System;

namespace ECommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Fashion"),
                new Product(3, "Phone", "Electronics"),
                new Product(4, "Book", "Education")
            };

            Console.WriteLine("Linear Search for 'Phone':");
            int index1 = SearchDemo.LinearSearch(products, "Phone");
            Console.WriteLine(index1 >= 0 ? $"Found at index {index1}" : "Not found");

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine("\nBinary Search for 'Shoes':");
            int index2 = SearchDemo.BinarySearch(products, "Shoes");
            Console.WriteLine(index2 >= 0 ? $"Found at index {index2}" : "Not found");
        }
    }
}
