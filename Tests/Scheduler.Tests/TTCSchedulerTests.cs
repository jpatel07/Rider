using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Scheduler.Tests
{
    [TestClass]
    public class TTCSchedulerTests
    {
        [TestMethod]
        public void ValidateStation()
        {
            TTCScheduler scheduler = new TTCScheduler();
            string stationName = "Finch";
            bool result = scheduler.ValidateStation(stationName);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateIgnoreCaseStation()
        {
            TTCScheduler scheduler = new TTCScheduler();
            string stationName = "DuPont";
            bool result = scheduler.ValidateStation(stationName);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateStationAndDirection()
        {
            TTCScheduler scheduler = new TTCScheduler();
            string stationName = "Dundas";
            string direction = "North";
            bool result = scheduler.ValidateStationDirection(stationName, direction);
            Assert.IsTrue(result);

        }
    }
}
