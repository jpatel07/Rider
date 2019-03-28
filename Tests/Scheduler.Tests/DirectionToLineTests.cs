using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduler;

namespace Scheduler.Tests
{
    /// <summary>
    /// Summary description for LineToDirectionTests
    /// </summary>
    [TestClass]
    public class DirectionToLineTests
    {
        public DirectionToLineTests()
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
        public void ValidateNorthToLine1Conversion()
        {
            int northSouthLineCount = 1;
            DirectionToLine.Direction testDirection = DirectionToLine.Direction.North;
            List<string> resultLines = DirectionToLine.ConvertToLines(testDirection);
            Assert.AreEqual(northSouthLineCount, resultLines.Count);
            Assert.AreEqual("Line1", resultLines[0]);

        }
        [TestMethod]
        public void ValidateWestToNonLine1Conversion()
        {
            int eastWestLineCount = 3;
            DirectionToLine.Direction testDirection = DirectionToLine.Direction.West;
            List<string> resultLines = DirectionToLine.ConvertToLines(testDirection);
            Assert.AreEqual(eastWestLineCount, resultLines.Count);
        }
    }
}
