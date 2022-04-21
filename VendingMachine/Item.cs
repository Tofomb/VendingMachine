namespace VendingMachine
{
    public abstract class Item
    {
        public abstract string Examine { get; set; }
        public abstract string Use { get; set; }
        public abstract int Price { get; set; }
        public abstract string Name { get; set; }
    }

}