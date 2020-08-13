using NUnit.Framework;

namespace QuantityMeasurementTest
{
    public class Tests
    {
         QuantityMeasurement.QuantityMeasurement quantityMeasurement;

        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
        }

        [Test]
        public void Given0FeetAnd0Feet_IfEqual_ShouldReturnTrue()
        {
            double feet1 = quantityMeasurement.ReturnFeet(0.0);
            double feet2 = quantityMeasurement.ReturnFeet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void Given0FeetAnd1Feet_IfNotEqual_ShouldReturnTrue()
        {
            double feet1 = quantityMeasurement.ReturnFeet(0.0);
            double feet2 = quantityMeasurement.ReturnFeet(1.0);
            Assert.AreNotEqual(feet1, feet2);
        }
    }
}