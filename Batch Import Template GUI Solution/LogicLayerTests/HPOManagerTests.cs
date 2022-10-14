using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataObjects;
using DataAccessLayer;
using LogicLayer;

namespace LogicLayerTests
{
    [TestClass]
    public class HPOManagerTests
    {

        private IHPOManager hPOManager = null;

        [TestInitialize]
        public void TestSetup()
        {
            hPOManager = new HPOManager(new FakeHPODDataAccessor());
        }


        [TestMethod]
        public void TestRetrieveListOfHPO()
        {
            // arrange
            const int expectedCount = 6;
            int actualCount = 0;

            // act
            actualCount = hPOManager.RetrieveHumanPhenotypeOntologyIdAndLabels().Count;

            // assert
            Assert.AreEqual(expectedCount,actualCount);
        }
    }
}
