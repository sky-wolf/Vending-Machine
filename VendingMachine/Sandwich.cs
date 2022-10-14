
namespace VendingMachine
{
    public class Sandwich : Product
    {
        public Sandwich(string name, int price, string info, string code) : base(name, price, info, code)
        {
        }

        //public override void Examine()
        //{
        //    Console.WriteLine($"Info: {Description}");
        //    Console.WriteLine($"Price: {Price}");
        //}

        public override string Use()
        {
            return "Eat the sandwich";
        }
    }
}
