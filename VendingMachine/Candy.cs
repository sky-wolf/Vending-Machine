
namespace VendingMachine
{
    public class Candy : Product
    {
        public Candy(string name, int price, string info, string code) : base(name, price, info, code)
        {
        }

        //public override void Examine()
        //{
        //    Console.WriteLine($"Info: {Description}");
        //    Console.WriteLine($"Price: {Price}");
        //}

        public override void Use()
        {
            Console.WriteLine("Eat the candy");
        }
    }
}
