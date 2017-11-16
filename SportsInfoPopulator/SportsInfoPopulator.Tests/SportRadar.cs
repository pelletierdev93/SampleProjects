using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsInfoPopulator;
using System.Threading;
using System.Threading.Tasks;

namespace SportsInfoPopulator.Tests
{
    [TestClass]
    public class SportRadar
    {
        [TestMethod]
        public async Task GetDivisions()
        {
            // Init vars
            var serv = new SportRadarService();
            // Create cancellation token
            var cts = new CancellationTokenSource(50000);
            // Call Web service with hope that we will get the correct data back
            var result = await serv.GetSportsData("Division", "conferences:divisions", cts.Token);
            // Check Result
            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public async Task GetConferences()
        {
            // Init vars
            var serv = new SportRadarService();
            // Create cancellation token
            var cts = new CancellationTokenSource(50000);
            // Call Web service with hope that we will get the correct data back
            var result = await serv.GetSportsData("Conferences", "conferences", cts.Token);
            // Check Result
            Assert.AreEqual(2, result.Count);
        }
    }
}
