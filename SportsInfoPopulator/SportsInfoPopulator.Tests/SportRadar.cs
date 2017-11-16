using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsInfoPopulator;
using System.Threading;

namespace SportsInfoPopulator.Tests
{
    [TestClass]
    public class SportRadar
    {
        [TestMethod]
        public void GetTeams()
        {
            // Init vars
            var serv = new SportRadarService();
            // Create cancellation token
            var cts = new CancellationTokenSource(5000);
            // Call Web service with hope that we will get the correct data back
            var result = serv.GetSportsData("Teams", cts.Token);
        }

        [TestMethod]
        public void GetConferences()
        {
            // Init vars
            var serv = new SportRadarService();
            // Create cancellation token
            var cts = new CancellationTokenSource(5000);
            // Call Web service with hope that we will get the correct data back
            var result = serv.GetSportsData("Conferences", cts.Token);
        }
    }
}
