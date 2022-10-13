using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace VendingMachine
{
    public class VendingManager : IVending
    {
        public List<Product> Products { get; }

        public readonly int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };

        public VendingManager()
        {
            Products = new List<Product>();
        }

        public int Pool { get; set; }

        public void EndTransaction()
        {
            foreach (int i in denominations)
            {
                Console.WriteLine($"{Pool / i} :{i}kr");
                Pool %= i;
            }
        }

        public bool InsertMoney(int insert)
        {
            if (denominations.Contains(insert))
            {
                Pool += insert;
                return true;
            }
            return false;
        }

        public void Purchase(string code)
        {
            foreach (Product product in Products)
            {
                if(product.Code == code && Pool >= product.Price)
                {
                    Pool -= product.Price;
                    product.Use();
                }
            }
            Console.WriteLine("Purchase not valid or efficient found was not available.");
        }

        public void ShowAll()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine($"Code: {product.Code} Name: {product.Name} Price: {product.Price}kr");
            }
        }

    }
}