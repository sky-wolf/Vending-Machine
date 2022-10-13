namespace VendingMachine
{
    public class Application
    {
        VendingManager vending = new VendingManager();

        public Application()
        {
            vending.Products.Add(new Beverage("Coca-Cola", 16, "A can of CocaCola", "B1"));
            vending.Products.Add(new Beverage("Pepsi Max", 16, "A can of Pepsi Max", "B2"));
            vending.Products.Add(new Beverage("Fanta", 16, "A can of Fanta", "B3"));
            vending.Products.Add(new Beverage("Must", 16, "A can of Must", "B4"));
            vending.Products.Add(new Candy("Chocolate Bar", 16, "A Chocolate Bar", "C1"));
            vending.Products.Add(new Candy("Bag of Chips", 21, "A Bag of Chips", "C2"));
            vending.Products.Add(new Candy("Bilar", 15, "A bag of candy shape as cars", "C3"));
            vending.Products.Add(new Candy("Kexchoklad", 25, "A bar of Chocolate coverd wafers", "C4"));
            vending.Products.Add(new Sandwich("Club sandwich", 30, "Club sandwich", "S1"));
            vending.Products.Add(new Sandwich("BLT sandwich", 30, "BLT sandwich", "S2"));
            vending.Products.Add(new Sandwich("Club sandwich", 30, "Club sandwich", "S3"));
            vending.Products.Add(new Sandwich("Ham & chees sandwich", 30, "Ham & chees sandwich", "S4"));
        }


        public void Run()
        {

            bool isRunning = true;
            InsertMoney();
            while (vending.Pool >= 1 && isRunning)
            {
                Console.Clear();
                Console.WriteLine($"Founds left: {vending.Pool}");
                vending.ShowAll();
                if (!input())
                {
                    isRunning = false;
                }
                Console.ReadKey();
            }
            vending.EndTransaction();
        }

        private bool input()
        {
            string code = "";
            bool ret = true;
            do
            {
                Console.WriteLine("Type R for geting change back, type I for Insert more monye.");
                Console.Write("Type the code for the iteme you wish to purchase: ");
                code = Console.ReadLine();

                if(code.ToUpper() == "R")
                {
                    ret = false;
                }
                else if (code.ToUpper() == "I")
                {
                    InsertMoney();
                }
                else
                {
                    vending.Purchase(code.ToUpper());
                }

                return ret;
            } while (true);
        }

        private void InsertMoney()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine($"Founds: {vending.Pool} End with 0");
                Console.WriteLine("Incert only valid denomination");

                foreach (int i in vending.denominations)
                {
                    Console.Write($"{i}kr ");
                }
                Console.WriteLine();

                Console.Write("Incert: ");
                int money = Convert.ToInt32(Console.ReadLine());
                
                if(money == 0)
                {
                    isRunning = false;
                }
                else
                {
                    if (!vending.InsertMoney(money))
                    {
                        Console.WriteLine("Wrong denomination");
                    }
                }                    
            }
        }
    }
}
