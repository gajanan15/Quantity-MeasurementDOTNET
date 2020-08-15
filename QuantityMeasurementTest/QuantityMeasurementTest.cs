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
         private double inchOne;
         private double inchTwo;
         private double millilitreOne;
         private double millilitreTwo;

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
        /// Test Case 1.1 Given Zero Feet And Zero Feet Should Return Equal.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndZeroFeet_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.1 Given Zero Feet And One Feet Should Return NotEqual.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndOneFeet_IfNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
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
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 2.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************INCH*******************************************************

        /// <summary>
        /// Test Case 1.6 Given Zero Inch And One Inch Should Return Equal.
        /// </summary>
         [Test]
         public void GivenZeroInchAndZeroInch_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.6 Given Zero Inch And One Inch Should Return NotEqual.
        /// </summary>
         [Test]
         public void GivenZeroInchAndOneInch_IfNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
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
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.11 To Check Given Zero Feet and Zero Inch Should Return equal.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndZeroInch_IfEquals_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.12 To Check Given One Feet and One Inch Are Not equal.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneInch_IfNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.13 To Check Given One Inch and One Feet Are Not equal.
        /// </summary>
         [Test]
         public void GivenOneInchAndOneFeet_IfNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.14 To Check Given One Feet is equal To Twelve Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndTwelveInch_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 12.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.15 To Check Given Twelve Inch is equal To One Feet.
        /// </summary>
         [Test]
         public void GivenTwelveInchAndOneFeet_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 12.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************YARD*******************************************************

        /// <summary>
        /// Test Case 2.1 To Check Given Zero Feet is Equal Zero Yard.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndZeroYard_WhenEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.1 To Check Given One Feet is equal To Zero Yard.
        /// </summary>
         [Test]
         public void GivenOneFeetAndZeroYard_WhenNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 0.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.2 To Check Given Three Feet is equal To One Yard.
        /// </summary>
         [Test]
         public void GivenThreeFeetAndOneYard_WhenEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 3.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.3 To Check Given One Feet is Not equal To One Yard.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneYard_WhenNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.4 To Check Given One Inch is Not equal To One Yard.
        /// </summary>
         [Test]
         public void GivenOneInchAndOneYard_WhenNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.5 To Check Given One Yard is equal To Thirty Six Inch.
        /// </summary>
         [Test]
         public void GivenOneYardAndThirtySixInch_WhenEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 36.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.6 To Check Given Thirty Six Inch is equal To One Yard.
        /// </summary>
         [Test]
         public void GivenThirtySixInchAndOneYard_WhenEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 36.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.7 To Check Given One Yard is equal To Three Feet.
        /// </summary>
         [Test]
         public void GivenOneYardAndThreeFeet_WhenEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 3.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************CENTIMETER*******************************************************

        /// <summary>
        /// Test Case 3.1 To Check Given Zero Centimeter is equal To Zero Centimeter.
        /// </summary>
         [Test]
         public void GivenZeroCentimeterAndZeroCentimeter_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 3.2 To Check Given Zero Centimeter is Not Equal To One Inch.
        /// </summary>
         [Test]
         public void GivenZeroCentimeterAndOneInch_IfNotEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 3.3 To Check Given Two Inch is Equal To Five Centimeter.
        /// </summary>
         [Test]
         public void GivenTwoInchAndFiveCentimeter_IfEqual_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 5.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************ADD TWO LENGTHS*******************************************************

        /// <summary>
        /// Test Case 4.1 Convert To Inch Two Inch And Two Inch Is Equal To Four Inch.
        /// </summary>
         [Test]
         public void GivenTwoInchAndTwoInch_WhenEqualToFourInch_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            double finalResult = this.quantityMeasurement.Add(this.inchOne, this.inchTwo);
            Assert.AreEqual(4.0d, finalResult);
        }

        /// <summary>
        /// Test Case 4.2 Convert To Inch One Feet And Two Inch Is Equal To Fourteen Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndTwoInch_WhenEqualToFourteenInch_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            double finalResult = this.quantityMeasurement.Add(this.inchOne, this.inchTwo);
            Assert.AreEqual(14.0d, finalResult);
        }

        /// <summary>
        /// Test Case 4.3 Convert To Inch One Feet And One Feet Is Equal To Twenty Four Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneFeet_WhenEqualToTwentyFourInch_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            double finalResult = this.quantityMeasurement.Add(this.inchOne, this.inchTwo);
            Assert.AreEqual(24.0d, finalResult);
        }

        /// <summary>
        /// Test Case 4.3 Convert To Inch Two Inch And Two Point Five Centimeter Is Equal To Three Inch.
        /// </summary>
         [Test]
         public void GivenTwoInchAndTwoPointFiveCentimeter_WhenEqualToThreeInch_ShouldReturnTrue()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 2.5);
            double finalResult = this.quantityMeasurement.Add(this.inchOne, this.inchTwo);
            Assert.AreEqual(3.0d, finalResult);
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++Volume+++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // ************************************************Gallon*******************************************************

        /// <summary>
        /// Test Case 5.1 To Check Given Zero Gallon is Equal To Zero Gallon.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndZeroGallon_WhenEqual_ShouldReturnTrue()
        {
            this.millilitreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.millilitreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            Assert.AreEqual(this.millilitreOne, this.millilitreTwo);
        }

        /// <summary>
        /// Test Case 5.2 To Check Given Zero Gallon is Equal To Zero Litre.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndZeroLitre_WhenEqual_ShouldReturnTrue()
        {
            this.millilitreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.millilitreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 0.0);
            Assert.AreEqual(this.millilitreOne, this.millilitreTwo);
        }

        /// <summary>
        /// Test Case 5.3 To Check Given Zero Gallon is Not Equal To One Litre.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndOneLitre_WhenNotEqual_ShouldReturnTrue()
        {
            this.millilitreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.millilitreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 1.0);
            Assert.AreNotEqual(this.millilitreOne, this.millilitreTwo);
        }

        /// <summary>
        /// Test Case 5.4 To Check Given One Gallon is Equal To Three point Seventy Eight Litre.
        /// </summary>
         [Test]
         public void GivenOneGallonAndThreePoinSeventyEightLitre_WhenEqual_ShouldReturnTrue()
        {
            this.millilitreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 1.0);
            this.millilitreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 3.785);
            Assert.AreEqual(this.millilitreOne, this.millilitreTwo);
        }

        /// <summary>
        /// Test Case 5.5 To Check Given One Litre is Equal To Thousand Millilitre.
        /// </summary>
         [Test]
         public void GivenOneLitreAndThousandMillilitre_WhenEqual_ShouldReturnTrue()
        {
            this.millilitreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 1.0);
            this.millilitreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.MILLILITRE, 1000.0);
            Assert.AreEqual(this.millilitreOne, this.millilitreTwo);
        }
    }
}