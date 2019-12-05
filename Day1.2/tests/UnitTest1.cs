using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC2019.Day1;

namespace AoC2019.Day1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private FuelCalculator fuelCalculator = new FuelCalculator();

        [TestMethod]
        public void TestMethod1()
        {
            var fule = fuelCalculator.CalculateForMass(12);
            Assert.IsTrue(fule == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var fule = fuelCalculator.CalculateForMass(14);
            Assert.IsTrue(fule == 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var fule = fuelCalculator.CalculateForMass(1969);
            Assert.IsTrue(fule == 654);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var fule = fuelCalculator.CalculateForMass(100756);
            Assert.IsTrue(fule == 33583);
        }
                
        [TestMethod]
        public void TestMethod5()
        {
            var fule = fuelCalculator.CalculateForMassWithFuel(14);
            Assert.IsTrue(fule == 2);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var fule = fuelCalculator.CalculateForMassWithFuel(1969);
            Assert.IsTrue(fule == 966);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var fule = fuelCalculator.CalculateForMassWithFuel(100756);
            Assert.IsTrue(fule == 50346);
        }
 

    }
}
