namespace VendingMachine
{
    public static class Backpack
    {


        public static string Look(List<Item> bpItem)
        {
            string ItemUse = "";
            int ii = 0;
            foreach (var item in bpItem)
            {
                ii++;
                Console.WriteLine($"{ii}. {item.Name}");
            }
            Console.WriteLine("choose an item");
            var choosenItem = Console.ReadLine();
            int.TryParse(choosenItem, out int choosenItemInt);
            choosenItemInt -= 1;
            Console.WriteLine("Do you want to (1) Examine or (2) Use it?");
            var choosenAction = Console.ReadLine();
            if (choosenAction == "1")
            {
               ItemUse = bpItem.ElementAt(choosenItemInt).Examine;
            }
            else if (choosenAction == "2")
            {
                ItemUse = bpItem.ElementAt(choosenItemInt).Use;
            }

            return ItemUse;
        }

    }

}