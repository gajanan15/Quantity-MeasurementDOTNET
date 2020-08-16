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
         private double litreOne;
         private double litreTwo;
         private double kilogramOne;
         private double kilogramTwo;
         private double temperatureOne;
         private double temperatureTwo;

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
         public void GivenZeroFeetAndZeroFeet_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 1 Feet Should Return NotEqual.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndOneFeet_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.2 Given Null Values Should Return Equal.
        /// </summary>
         [Test]
         public void GivenNullValueForFeet_WhenChecked_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test Case 1.3 Given References Having Same Object Should Return Equal.
        /// </summary>
         [Test]
         public void GivenReferenceForFeet_WhenChecked_ShouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurement.Equals(this.quantityMeasurement));
        }

        /// <summary>
        /// Test Case 1.4 To Cehck Equal Type.
        /// </summary>
         [Test]
         public void GivenType_WhenChecked_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test Case 1.5 To Check Values Are Equels.
        /// </summary>
         [Test]
         public void GivenValueCheck_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 2.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************INCH*******************************************************

        /// <summary>
        /// Test Case 1.6 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
         [Test]
         public void GivenZeroInchAndZeroInch_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.6 Given 0 Inch And 1 Inch Should Return NotEqual.
        /// </summary>
         [Test]
         public void GivenZeroInchAndOneInch_WhenCompared_ShouldReturnNotEqual()
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
         public void GivenTypeForInch_WhenCompared_ShouldReturnEqual()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test Case 1.10 To Check Values Are Equels.
        /// </summary>
         [Test]
         public void GivenValueCheckForInch_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.11 To Check Given 0 Feet and 0 Inch Should Return equal.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndZeroInch_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.12 To Check Given 1 Feet and 1 Inch Are Not equal.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneInch_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.13 To Check Given 1 Inch and 1 Feet Are Not equal.
        /// </summary>
         [Test]
         public void GivenOneInchAndOneFeet_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.14 To Check Given 1 Feet is equal To 12 Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndTwelveInch_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 12.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 1.15 To Check Given 12 Inch is equal To 1 Feet.
        /// </summary>
         [Test]
         public void GivenTwelveInchAndOneFeet_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 12.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************YARD*******************************************************

        /// <summary>
        /// Test Case 2.1 To Check Given 0 Feet is Equal 0 Yard.
        /// </summary>
         [Test]
         public void GivenZeroFeetAndZeroYard_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.1 To Check Given 1 Feet is equal To 0 Yard.
        /// </summary>
         [Test]
         public void GivenOneFeetAndZeroYard_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 0.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.2 To Check Given 3 Feet is equal To 1 Yard.
        /// </summary>
         [Test]
         public void GivenThreeFeetAndOneYard_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 3.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.3 To Check Given 1 Feet is Not equal To 1 Yard.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneYard_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.4 To Check Given 1 Inch is Not equal To 1 Yard.
        /// </summary>
         [Test]
         public void GivenOneInchAndOneYard_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.5 To Check Given 1 Yard is equal To 36 Inch.
        /// </summary>
         [Test]
         public void GivenOneYardAndThirtySixInch_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 36.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.6 To Check Given 36 Inch is equal To 1 Yard.
        /// </summary>
         [Test]
         public void GivenThirtySixInchAndOneYard_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 36.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 2.7 To Check Given 1 Yard is equal To 3 Feet.
        /// </summary>
         [Test]
         public void GivenOneYardAndThreeFeet_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.YARD, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 3.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************CENTIMETER*******************************************************

        /// <summary>
        /// Test Case 3.1 To Check Given 0 Centimeter is equal To 0 Centimeter.
        /// </summary>
         [Test]
         public void GivenZeroCentimeterAndZeroCentimeter_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 3.2 To Check Given 0 Centimeter is Not Equal To 1 Inch.
        /// </summary>
         [Test]
         public void GivenZeroCentimeterAndOneInch_WhenCompared_ShouldReturnNotEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 0.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 1.0);
            Assert.AreNotEqual(this.inchOne, this.inchTwo);
        }

        /// <summary>
        /// Test Case 3.3 To Check Given 2 Inch is Equal To 5 Centimeter.
        /// </summary>
         [Test]
         public void GivenTwoInchAndFiveCentimeter_WhenCompared_ShouldReturnEqual()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 5.0);
            Assert.AreEqual(this.inchOne, this.inchTwo);
        }

        // ************************************************ADD TWO LENGTHS*******************************************************

        /// <summary>
        /// Test Case 4.1 Convert To Inch 2 Inch And 2 Inch Is Equal To 4 Inch.
        /// </summary>
         [Test]
         public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnFour()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            double finalResult = this.quantityMeasurement.AddConversion(this.inchOne, this.inchTwo);
            Assert.AreEqual(4.0, finalResult);
        }

        /// <summary>
        /// Test Case 4.2 Convert To Inch 1 Feet And 2 Inch Is Equal To 14 Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnFourteen()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            double finalResult = this.quantityMeasurement.AddConversion(this.inchOne, this.inchTwo);
            Assert.AreEqual(14.0, finalResult);
        }

        /// <summary>
        /// Test Case 4.3 Convert To Inch 1 Feet And 1 Feet Is Equal To 24 Inch.
        /// </summary>
         [Test]
         public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnTwentyFour()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FEET, 1.0);
            double finalResult = this.quantityMeasurement.AddConversion(this.inchOne, this.inchTwo);
            Assert.AreEqual(24.0, finalResult);
        }

        /// <summary>
        /// Test Case 4.4 Convert To Inch 2 Inch And 2.5 Centimeter Is Equal To 3 Inch.
        /// </summary>
         [Test]
         public void GivenTwoInchAndTwoPointFiveCentimeter_WhenAdded_ShouldReturnThree()
        {
            this.inchOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.INCHES, 2.0);
            this.inchTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CENTIMETER, 2.5);
            double finalResult = this.quantityMeasurement.AddConversion(this.inchOne, this.inchTwo);
            Assert.AreEqual(3.0, finalResult);
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++Volume+++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Test Case 5.1 To Check Given 0 Gallon is Equal To 0 Gallon.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndZeroGallon_WhenCompared_ShouldReturnEqual()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            Assert.AreEqual(this.litreOne, this.litreTwo);
        }

        /// <summary>
        /// Test Case 5.2 To Check Given 0 Gallon is Equal To 0 Litre.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndZeroLitre_WhenCompared_ShouldReturnEqual()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 0.0);
            Assert.AreEqual(this.litreOne, this.litreTwo);
        }

        /// <summary>
        /// Test Case 5.3 To Check Given 0 Gallon is Not Equal To 1 Litre.
        /// </summary>
         [Test]
         public void GivenZeroGallonAndOneLitre_WhenCompared_ShouldReturnNotEqual()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 0.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 1.0);
            Assert.AreNotEqual(this.litreOne, this.litreTwo);
        }

        /// <summary>
        /// Test Case 5.4 To Check Given 1 Gallon is Equal To 3.785 Litre.
        /// </summary>
         [Test]
         public void GivenOneGallonAndThreePoinSeventyEightLitre_WhenCompared_ShouldReturnEqual()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 1.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 3.785);
            Assert.AreEqual(this.litreOne, this.litreTwo);
        }

        /// <summary>
        /// Test Case 5.5 To Check Given 1 Litre is Equal To 1000 Millilitre.
        /// </summary>
         [Test]
         public void GivenOneLitreAndThousandMillilitre_WhenCompared_ShouldReturnEqual()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 1.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.MILLILITRE, 1000.0);
            Assert.AreEqual(this.litreOne, this.litreTwo);
        }

        // ************************************************Add Volumes In Litres*******************************************************

        /// <summary>
        /// Test Case 6.1 Convert To Litre 1 Gallon And 3.785 Litre Is Equal To Seven Point Fifty Seven Litre.
        /// </summary>
         [Test]
         public void GivenOneGallonAndThreePointSeventyEightLitre_WhenAdded_ShouldReturnSevenPointFiftySevenLitre()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GALLON, 1.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 3.785);
            double finalResult = this.quantityMeasurement.AddConversion(this.litreOne, this.litreTwo);
            Assert.AreEqual(7.57, finalResult);
        }

        /// <summary>
        /// Test Case 6.2 Convert To Litre Given 1 Litre And 1000 Millilitre Is Equal To 2 Litre.
        /// </summary>
         [Test]
         public void GivenOneLitreAndThousandMillilitre_WhenAdded_ShouldReturnTwoLitre()
        {
            this.litreOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.LITRE, 1.0);
            this.litreTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.MILLILITRE, 1000.0);
            double finalResult = this.quantityMeasurement.AddConversion(this.litreOne, this.litreTwo);
            Assert.AreEqual(2.0, finalResult);
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++Weight+++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Test Case 7.1 To Check Given 1 Kilogram is Equal To 1000 Gram.
        /// </summary>
         [Test]
         public void GivenOneKilogramAndThousandGram_WhenCompare_ShouldReturnEqual()
        {
            this.kilogramOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.KILOGRAM, 1.0);
            this.kilogramTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GRAM, 1000.0);
            Assert.AreEqual(this.kilogramOne, this.kilogramTwo);
        }

        /// <summary>
        /// Test Case 7.2 To Check Given 1 Tonne is Equal To 1000 Kilogram.
        /// </summary>
         [Test]
         public void GivenOneTonneAndThousandKilogram_WhenCompare_ShouldReturnEqual()
        {
            this.kilogramOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.TONNE, 1.0);
            this.kilogramTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.KILOGRAM, 1000.0);
            Assert.AreEqual(this.kilogramOne, this.kilogramTwo);
        }

        /// <summary>
        /// Test Case 7.3 Convert To Kilogram Given 1 Tonne And 1000 Gram Is Equal To 1001 Kilogram.
        /// </summary>
         [Test]
         public void GivenOneTonneAndThousandGram_WhenAdded_ShouldReturnOneThousandOneKilogram()
        {
            this.kilogramOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.TONNE, 1.0);
            this.kilogramTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.GRAM, 1000.0);
            double finalResult = this.quantityMeasurement.AddConversion(this.kilogramOne, this.kilogramTwo);
            Assert.AreEqual(1001.0, finalResult);
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++Temperature+++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Test Case 8 To Check Given 212 Fahrenheit is Equal To 100 Celsius.
        /// </summary>
         [Test]
         public void GivenTwoHundredAndTwelveFahrenheitAndHundredCelsius_WhenCompare_ShouldReturnEqual()
        {
            this.temperatureOne = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.FAHRENHEIT, 212.0);
            this.temperatureTwo = this.quantityMeasurement.ReturnUnits(QuantityMeasurement.UnitTypeEnum.UnitType.CELSIUS, 100.0);
            Assert.AreEqual(this.temperatureOne, this.temperatureTwo);
        }
    }
}