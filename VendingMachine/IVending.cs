namespace VendingMachine
{
    interface IVending
    {
        ReturnPurchase Purchase(int moneyPool);
        void ShowAll();
        int InsertMoney(int moneyPool);
        int EndTransaction(int moneyPool);
    }

}