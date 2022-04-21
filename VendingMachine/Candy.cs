namespace VendingMachine
{
    public class Candy : Item
    {
        public Candy()
        {
            Name = "Wobb-bar";
            Price = 12;
            Examine = $"It's a fluffy {this.Name}, it costs {Price} kr";
            Use = "The taste of chocolate will never wash of your fingers!";
        }

        public override string Examine { get; set; }
        public override string Use { get; set; }
        public override int Price { get; set; }
        public override string Name { get; set; }
    }

}