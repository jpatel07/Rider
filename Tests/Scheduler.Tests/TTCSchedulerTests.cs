﻿using System;
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
    }
}
