namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        public List<Item> Inventory { get; set; }

        public VendingMachine()
        {
            Inventory = new List<Item>();
            Inventory.Add(new FlobbWobbler());
            Inventory.Add(new FlobbWobbler());
            Inventory.Add(new FlobbWobbler());
            Inventory.Add(new Drink());
            Inventory.Add(new Drink());
            Inventory.Add(new Drink());
            Inventory.Add(new Candy());
        }

        public int EndTransaction(int moneyPool)
        {
            int[] change = new int[Valuta.valuta.Length];
            int counter = 0;
            foreach (var vType in Valuta.valuta.Reverse())
            {
                while (moneyPool >= vType)
                {
                    change[counter]++;
                    moneyPool -= vType;
                }
                counter++;
            }
            Console.WriteLine($"returns: ");
            for (int ii = 0; ii < Valuta.valuta.Length; ii++)
            {
                if (change[ii] > 0)
                {
                    Console.Write($"{change[ii]} {Valuta.valuta[Valuta.valuta.Length - ii - 1]}kr, ");

                }
            }
            Console.WriteLine();
            return 0;

        }

        public int InsertMoney(int moneyPool)
        {
            Console.WriteLine("Insert money:");
            // var possibleMoney = 0;
            int.TryParse(Console.ReadLine(), out int possibleMoney);
            if (Valuta.valuta.Contains(possibleMoney))
            {
                moneyPool += possibleMoney;
            }
            else
            {
                Console.WriteLine("Not valid amount");
            }
            return moneyPool;
        }

        public ReturnPurchase Purchase(int moneyPool)
        {
            ReturnPurchase rp = new ReturnPurchase();
            ShowAll();
            Console.WriteLine("Make a chocie of product");
            bool trueChoice = int.TryParse(Console.ReadLine(), out int choice);
            choice -= 1;

            if (trueChoice && choice >= 0 && choice <= this.Inventory.Count())
            {
                if (this.Inventory[choice].Price > moneyPool)
                {
                    Console.WriteLine("Not enough money...");
                }
                else
                {
                    rp.PurchasedItem = this.Inventory[choice];
                    moneyPool -= this.Inventory[choice].Price;
                    this.Inventory.RemoveAt(choice);
                }
            }


            rp.MonneyPool = moneyPool;

            return rp;
        }

        public void ShowAll()
        {
            int counter = 0;
            foreach (var item in this.Inventory)
            {
                counter++;
                Console.WriteLine($"{counter} {item.Name} {item.Price} kr.");
            }
        }
    }

}