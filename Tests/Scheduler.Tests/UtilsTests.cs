using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduler;
using System.IO;

namespace Scheduler.Tests
{
    /// <summary>
    /// Summary description for UtilsTests
    /// </summary>
    [TestClass]
    public class UtilsTests
    {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        public UtilsTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadStationsLoadMissingFilesFileNotFound()
        {
            string fileName = "someName";

            var stations = Utils.LoadStations(fileName);
            Assert.IsNotNull(stations);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadStationsThrowsInvalidArugment()
        {
            string fileName = string.Empty;
            Utils.LoadStations(fileName);
        }

        [TestMethod]
        public void LoadStationLoadValidFiles()
        {

            string fileName = "stationsmasterdata.csv";
            string filePath = Path.Combine(baseDir, fileName);
            var stations = Utils.LoadStations(filePath);
            Assert.AreEqual(75, stations.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidHourTimeSpanThrows()
        {
            int hour = 81;
            int minute = 0;
            TimeSpan nextTimeSpan = Utils.GetNextTrainArrivalTime(hour, minute);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidMintuesTimeSpanThrows()
        {
            int hour = 12;
            int minute = 61;
            TimeSpan nextTimeSpan = Utils.GetNextTrainArrivalTime(hour, minute);

        }
    }
}
