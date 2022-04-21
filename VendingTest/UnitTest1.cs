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

    }
}