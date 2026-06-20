import java.util.Arrays;

public class SearchDemo {

    // Linear Search
    public static Product linearSearch(Product[] products, int productId) {
        for (Product p : products) {
            if (p.getProductId() == productId) {
                return p;
            }
        }
        return null;
    }

    // Binary Search (requires sorted array by productId)
    public static Product binarySearch(Product[] products, int productId) {
        int left = 0, right = products.length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (products[mid].getProductId() == productId) {
                return products[mid];
            } else if (products[mid].getProductId() < productId) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return null;
    }

    public static void main(String[] args) {
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Book", "Education")
        };

        // Sort products by productId for binary search
        Arrays.sort(products, (a, b) -> Integer.compare(a.getProductId(), b.getProductId()));

        // Linear Search
        Product result1 = linearSearch(products, 103);
        System.out.println("Linear Search Result: " + result1);

        // Binary Search
        Product result2 = binarySearch(products, 103);
        System.out.println("Binary Search Result: " + result2);
    }
}
