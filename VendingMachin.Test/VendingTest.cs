using VendingMachine;

namespace VendingMachin.Test
{
    public class VendingTest
    {
        [Fact]
        public void DenominationContainsTest()
        {
            VendingManager spt = new VendingManager();

            Assert.Contains((int)1000, spt.denominations);
            Assert.Contains((int)500, spt.denominations);
            Assert.Contains((int)100, spt.denominations);
            Assert.Contains((int)50, spt.denominations);
            Assert.Contains((int)20, spt.denominations);
            Assert.Contains((int)10, spt.denominations);
            Assert.Contains((int)5, spt.denominations);
            Assert.Contains((int)1, spt.denominations);
        }

        [Fact]
        public void ContainsProductsTest()
        {
            VendingManager spt = new VendingManager();
            spt.Products.Add(new Beverage("Coca-Cola", 16, "A can of CocaCola", "B1"));
            spt.Products.Add(new Candy("Chocolate Bar", 16, "A Chocolate Bar", "C1"));
            spt.Products.Add(new Sandwich("Club sandwich", 30, "Club sandwich", "S1"));

            Assert.NotEmpty(spt.Products);
        }

        [Fact]
        public void InsertMoneyFailTest()
        {
            VendingManager spt = new VendingManager();

            Assert.False(spt.InsertMoney(1500));

            Assert.Equal((int)0, spt.Pool);

        }

        [Fact]
        public void InsertMoneyTest()
        {
            VendingManager spt = new VendingManager();

            Assert.True(spt.InsertMoney(1000));

            Assert.Equal((int)1000, spt.Pool);

        }

        [Fact]
        public void PurchaseTest()
        {
            VendingManager spt = new VendingManager();
            spt.Products.Add(new Beverage("Coca-Cola", 16, "A can of CocaCola", "B1"));
            spt.Pool = 20;

            spt.Purchase("B1");
            Assert.Equal((int)4, spt.Pool);

            spt.Purchase("B1");
            Assert.Equal((int)4, spt.Pool);

        }

        [Fact]
        public void EndTransactionTest()
        {
            VendingManager spt = new VendingManager();

            spt.Pool = 1670;

            spt.EndTransaction();

            Assert.Equal((int)0, spt.Pool);

        }
    }
}