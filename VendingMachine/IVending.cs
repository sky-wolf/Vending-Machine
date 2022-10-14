namespace VendingMachine
{
    public interface IVending
    {
        string Purchase(string code);

        void ShowAll();

        bool InsertMoney(int insert);

        void EndTransaction();

    }
}
