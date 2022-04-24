namespace VendingMachine
{
    public class FlobbWobbler : Item
    {
        public FlobbWobbler()
        {
            this.Name = "Flobwobbler";
            this.Price = 135;
            this.Use = $"Everybody loves {this.Name}s, and it only cost {this.Price} kr!";
            Random rnd = new Random();
            int dice = rnd.Next(1, 11);
            if (dice == 10)
            {
                this.UltraRare = true;
            }
            else
                this.UltraRare = false;

            this.Examine = this.UltraRare == true ? $"It is a ultra rare {this.Name}, sparkling with joy for battle!" : $"It is super rare {this.Name}, dim with anticipation for the upcoming battle!";
        }

        public override string Examine { get; set; }
        public override string Use { get; set; }
        public bool UltraRare { get; set; }
        public override int Price { get; set; }
        public override string Name { get; set; }

    }

}