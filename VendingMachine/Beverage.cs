
namespace VendingMachine
{
    public class Beverage : Product
    {
        public Beverage(string name, int price, string info, string code) : base(name, price, info, code)
        {
        }

        //public override void Examine()
        //{
        //    Console.WriteLine($"Info: {Description}");
        //    Console.WriteLine($"Price: {Price}");
        //}

        public override string Use()
        {
            return "Drink the Beverage";
        }
    }
}
