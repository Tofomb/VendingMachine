namespace VendingMachine
{
    public class Drink : Item
    {
        public Drink()
        {
            Name = "FlobbCola";
            Price = 15;
            Examine = $"It's a fresh {this.Name}, it costs {Price} kr";
            Use = "It's half empty, what a perk!";
        }


        public override string Examine { get; set; }
        public override string Use { get; set; }
        public override int Price { get; set; }
        public override string Name { get; set; }
    }

}