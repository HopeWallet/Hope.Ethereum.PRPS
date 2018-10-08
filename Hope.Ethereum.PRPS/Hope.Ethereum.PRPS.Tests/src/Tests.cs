using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Hope.Ethereum.PRPSTests
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        public async Task TestSupply()
        {
            var prps = new PRPS.PRPS();
            var supply = await prps.QueryTotalSupply();

            Assert.IsTrue(supply > 0);
        }

        [TestMethod]
        public async Task TestBalanceOf()
        {
            var prps = new PRPS.PRPS();
            var balance = await prps.QueryBalanceOf("0xe4D688Bb2d5B7F546052cB6Fef3aEd8af8AF6511");

            Assert.IsTrue(balance > 0);
        }
    }
}
