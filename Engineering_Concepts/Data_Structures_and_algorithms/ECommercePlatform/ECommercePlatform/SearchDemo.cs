using System;

namespace ECommercePlatform
{
    public class SearchDemo
    {
        // Linear Search
        public static int LinearSearch(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        // Binary Search (requires sorted array)
        public static int BinarySearch(Product[] products, string name)
        {
            int left = 0, right = products.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int cmp = string.Compare(products[mid].ProductName, name, true);

                if (cmp == 0) return mid;
                if (cmp < 0) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
