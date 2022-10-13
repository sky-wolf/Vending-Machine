namespace VendingMachine
{
    public interface IVending
    {
        void Purchase(string code);

        void ShowAll();

        bool InsertMoney(int insert);

        void EndTransaction();

    }
}
