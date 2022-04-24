using Xunit;
using VendingMachine;
using System.Linq;

namespace VendingTest
{
    public class UnitTest1
    {

        [Fact]
        public void ItemCheck()
        {
            VendingMachine.VendingMachine machine = new();
            foreach(var item in machine.Inventory)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void Valuta()
        {            
            Assert.Equal(1, VendingMachine.Valuta.valuta[0]);
            Assert.Equal(5, VendingMachine.Valuta.valuta[1]);
            Assert.Equal(10, VendingMachine.Valuta.valuta[2]);
        }

        [Fact]
        public void ColaPrice()
        {
            Drink drink = new Drink();
            Assert.Equal(15, drink.Price);
        }

        [Fact]
        public void EndTrans()
        {
            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            Assert.Equal(0, vm.EndTransaction(1011));
        }

    }
}