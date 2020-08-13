// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;

    /// <summary>
    /// Create Test Calss.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Creating Instance Of Main Class.
        /// </summary>
         private QuantityMeasurement.QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// Craete SetUp Method.
        /// </summary>
         [SetUp]
         public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
        }

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
         [Test]
         public void Given0FeetAnd0Feet_IfEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnFeet(0.0);
            double feet2 = this.quantityMeasurement.ReturnFeet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 1 Feet Should Return NotEqual.
        /// </summary>
         [Test]
         public void Given0FeetAnd1Feet_IfNotEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnFeet(0.0);
            double feet2 = this.quantityMeasurement.ReturnFeet(1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.2 Given Null Values Should Return Equal.
        /// </summary>
         [Test]
         public void GivenNullValueForFeet_IfEqual_ShouldReturnFalse()
        {
            bool equals = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(equals);
        }
    }
}