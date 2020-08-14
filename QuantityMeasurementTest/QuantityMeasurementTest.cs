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

        // ************************************************FEET*******************************************************

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
         [Test]
         public void Given0FeetAnd0Feet_IfEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 0.0);
            double feet2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 1 Feet Should Return NotEqual.
        /// </summary>
         [Test]
         public void Given0FeetAnd1Feet_IfNotEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 0.0);
            double feet2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.2 Given Null Values Should Return Equal.
        /// </summary>
         [Test]
         public void GivenNullValueForFeet_IfEqual_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test Case 1.3 Given References Having Same Object Should Return Equal.
        /// </summary>
         [Test]
         public void GivenReferenceForFeet_IfEqual_ShouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test Case 1.4 To Cehck Equal Type.
        /// </summary>
         [Test]
         public void GivenType_IfEqual_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test Case 1.5 To Check Values Are Equels.
        /// </summary>
         [Test]
         public void GivenValueCheck_IfEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 2.0);
            double feet2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 2.0);
            Assert.AreEqual(feet1, feet2);
        }

        // ************************************************INCH*******************************************************

        /// <summary>
        /// Test Case 1.6 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
         [Test]
         public void Given0InchAnd0Inch_IfEqual_ShouldReturnTrue()
        {
            double inch1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 0.0);
            double inch2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.6 Given 0 Inch And 1 Inch Should Return NotEqual.
        /// </summary>
         [Test]
         public void Given0InchAnd1Inch_IfNotEqual_ShouldReturnTrue()
        {
            double inch1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 0.0);
            double inch2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.7 Given Null Values Should Return Equal.
        /// </summary>
         [Test]
         public void GivenNullValueForInch_WhenChecked_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test Case 1.8 Given References Having Same Object Should Return Equal.
        /// </summary>
         [Test]
         public void GivenReferenceForInch_WhenChecked_ShouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test Case 1.9 To Cehck Equal Type.
        /// </summary>
         [Test]
         public void GivenTypeForInch_IfEqual_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test Case 1.10 To Check Values Are Equels.
        /// </summary>
         [Test]
         public void GivenValueCheckForInch_IfEqual_ShouldReturnTrue()
        {
            double feet1 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 2.0);
            double feet2 = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 2.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.11 To Check Given 0 Feet and 0 Inch Should Return equal.
        /// </summary>
         [Test]
         public void Given0FeetAnd0Inch_IfEquals_ShouldReturnTrue()
        {
            double feet = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 0.0);
            double inch = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 0.0);
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Test Case 1.12 To Check Given 1 Feet and 1 Inch Are Not equal.
        /// </summary>
         [Test]
         public void Given1FeetAnd1Inch_IfNotEqual_ShouldReturnTrue()
        {
            double feet = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 1.0);
            double inch = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 1.0);
            Assert.AreNotEqual(feet, inch);
        }

        /// <summary>
        /// Test Case 1.13 To Check Given 1 Inch and 1 Feet Are Not equal.
        /// </summary>
         [Test]
         public void Given1InchAnd1Feet_IfNotEqual_ShouldReturnTrue()
        {
            double inch = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 1.0);
            double feet = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 1.0);
            Assert.AreNotEqual(inch, feet);
        }

        /// <summary>
        /// Test Case 1.14 To Check Given 1 Feet is equal To 12 Inch.
        /// </summary>
         [Test]
         public void Given1FeetAnd12Inch_IfEqual_ShouldReturnTrue()
        {
            double inch = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.FEET, 1.0);
            Assert.AreEqual(12.0d, inch);
        }

        /// <summary>
        /// Test Case 1.15 To Check Given 12 Inch is equal To 1 Feet.
        /// </summary>
         [Test]
         public void Given12InchAnd1Feet_IfEqual_ShouldReturnTrue()
        {
            double feet = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.LengthTypeEnum.LengthType.INCHES, 12.0);
            Assert.AreEqual(1.0d, feet);
        }
    }
}