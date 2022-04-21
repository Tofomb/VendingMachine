namespace VendingMachine
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool inUse = true;
            List<Item> backpack = new List<Item>();
            int moneyPool = 0;
            VendingMachine vm = new VendingMachine();
            while (inUse)
            {
                Console.WriteLine("Current money: " + moneyPool);
                Console.WriteLine("1. Purches, 2. Show All, 3. Insert Money, 4. End Transaction, 5 Look in Backpack.");
                Item item = new FlobbWobbler();
                var choice = Console.ReadLine();

                // by something from vendingmachine
                if (choice == "1" && vm.Inventory.Count() > 0)
                {
                    var purchasedItem = vm.Purchase(moneyPool);
                    moneyPool = purchasedItem.MonneyPool;
                    if (purchasedItem.PurchasedItem != null)
                    {
                        backpack.Add(purchasedItem.PurchasedItem);
                    }
                }
                //show all items in vending machine
                else if (choice == "2")
                {
                    vm.ShowAll();
                }
                //add money
                else if (choice == "3")
                {
                    moneyPool = vm.InsertMoney(moneyPool);
                }

                //End transaction
                else if (choice == "4")
                {
                    moneyPool = vm.EndTransaction(moneyPool);
                    inUse = false;
                }
                //Backpack
                else if (choice == "5" && backpack.Count>0)
                {
                    Console.WriteLine(Backpack.Look(backpack));
                }
            }
        }

        
    }
    public class Valuta
    {
        //usable money
        public static readonly int[] valuta = { 1, 5, 10, 20, 50, 100, 500, 1000 };
    }

}