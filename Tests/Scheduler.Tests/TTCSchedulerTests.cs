using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Scheduler.Tests
{
    [TestClass]
    public class TTCSchedulerTests
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void CatchNextTrainThrows()
        {
            TTCScheduler scheduler = new TTCScheduler();
            scheduler.CatchNextTrain("unknonw", DateTime.Now);
        }
    }
}
