
namespace VendingMachine
{
    public abstract class Product
    {
        protected Product(string name, int price, string info, string code)
        {
            Name = name;
            Price = price;
            Description = info;
            Code = code;
        }

        public string Code { get; }
        public string Name { get; }
        public string Description { get; }
        public int Price { get; }

        public void Examine()
        {
            Console.WriteLine($"Info: {Description}");
            Console.WriteLine($"Price: {Price}");
        }

        public abstract string Use();
    }
}
