using NUnit.Framework;
using QualityMeasurementProblem;
namespace QualityTest
{
    public class Tests
    {
        //Object Creation
        readonly Length length = new Length();
        readonly Volume volume = new Volume();
        readonly Weight weight = new Weight();

        [SetUp]
        public void Setup()
        {
        }

        /// <Test 1.1>
        /// Checking instance of Conversion are equal or not
        /// </Test1.1>
        [Test]
        public void CheckGivenZeroFeetReturnZero()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 0.0);
            bool equals = firstFeet.Equals(secondFeet);
            Assert.IsTrue(equals);
        }

        /// <Test 1.2>
        /// Checking instance of Conversion that it is null or not
        /// </Test 1.2>
        [Test]
        public void CheckGivenZNullFeetEqualToReturnNullFeet()
        {
            bool equals = Length.Equals(Length.Unit.FEET, null);
            Assert.IsFalse(equals);
        }

        /// <Test 1.3>
        /// Checking instance of Feet that referance is equal or not
        /// </Test 1.3>
        [Test]
        public void CheckGivenReferanceFeetEqualToGivenReferanceFeet()
        {
            //Instance of Conversion
            Length firstReferanceFeet = new Length();
            Length secondReferanceFeet = firstReferanceFeet;
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <Test 1.4>
        /// Checking instance of Feet's type equal or not
        /// </Test 1.4>
        [Test]
        public void CheckGivenTypeFeetEqualToReturnTypeFeet()
        {
            //Instance of Conversion
            Length firstFeetValue = new Length(Length.Unit.FEET, 0.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(firstFeetValue.GetType(), secondFeetValue.GetType());
        }

        /// <Test 1.5>
        /// Checking instance of Feet's and checking enequality
        /// </Test 1.5>
        [Test]
        public void CheckGivenFirstFeetNotEqualToSecondFeetReturnBoolValue()
        {
            //Instance of Conversion
            Length firstFeetValue = new Length(Length.Unit.FEET, 1.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 0.0);
            //Checking first and second values are equal or not. If it returns false test Pass
            bool equals = firstFeetValue.Equals(secondFeetValue);
            Assert.IsFalse(equals);
        }

        /// <Test 1.6>
        /// Checking instance of Inch are equal or not
        /// </Test1.6>
        [Test]
        public void CheckGivenZeroInchReturnZero()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 0.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsTrue(equals);
        }

        /// <Test 1.7>
        /// Checking instance of inch that it is null or not
        /// </Test 1.7>
        [Test]
        public void CheckGivenZNullInchEqualToReturnNullInch()
        {
            bool equals = Length.Equals(Length.Unit.INCH, null);
            Assert.IsFalse(equals);
        }

        /// <Test 1.8>
        /// Checking instance of Inch that referance is equal or not
        /// </Test 1.8>
        [Test]
        public void CheckGivenReferanceInchEqualToGivenReferanceInch()
        {
            //Instance of Conversion
            Length firstReferanceInch = new Length();
            Length secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <Test 1.9>
        /// Checking instance of Inch's type equal or not
        /// </Test 1.9>
        [Test]
        public void CheckGivenTypeInchEqualToReturnTypeInch()
        {
            //Instance of Conversion
            Length firstInchValue = new Length(Length.Unit.INCH, 0.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <Test 1.10>
        /// Checking instance of Inch's and checking enequality
        /// </Test 1.10>
        [Test]
        public void CheckGivenFirstInchNotEqualToSecondInchReturnBoolValue()
        {
            //Instance of Conversion
            Length firstInchValue = new Length(Length.Unit.INCH, 1.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 0.0);
            //Checking first and second values are equal or not. If it returns false test Pass
            bool equals = firstInchValue.Equals(secondInchValue);
            Assert.IsFalse(equals);
        }

        /// <Test 1.11>
        /// Checking instance of Length are equal or not Checking Inch Feet Equality
        /// </Test1.11>
        [Test]
        public void CheckGivenZeroFeetAndZeroInchAreEqual()
        {
            double zeroFeet = length.LengthConversion("FeetToInch",0.0);
            double zeroInch = length.LengthConversion("InchToFeet",0.0);
            Assert.AreEqual(zeroFeet, zeroInch);
        }

        /// <Test 1.12>
        /// Checking 1 feet is not equal to 1 inch
        /// </Test1.12>
        [Test]
        public void CheckGivenOneFeetIsNotEqualToOneInch()
        {
            double oneFeet = length.LengthConversion("FeetToInch",1.0);
            double oneInch = length.LengthConversion("InchToFee", 1.0);
            Assert.AreNotEqual(oneFeet, oneInch);
        }

        /// <Test 1.13>
        /// Checking 1 Inch is not equal to 1 Foot
        /// </Test1.13>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneFeet()
        {
            double oneInch = length.LengthConversion("InchToFeet",1.0);
            double oneFeet = length.LengthConversion("FeetToInch", 1.0);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <Test 1.14>
        /// Checking 1 Feet is equal to 12 Inch
        /// </Test1.14>
        [Test]
        public void CheckGivenOneFeetIsEqualToTwelveInch()
        {
            double oneFeet = length.LengthConversion("FeetToInch", 1.0);
            double twelveInch = 12.0;
            Assert.AreEqual(oneFeet,twelveInch);
        }

        /// <Test 1.15>
        /// Checking 12 Inch is equal to 1 feet
        /// </Test1.15>
        [Test]
        public void CheckGivenTwelveInchIsEqualToOneFeet()
        {
            double oneFeet = 1.0;
            double twelveInch = length.LengthConversion("InchToFeet",12.0);
            Assert.AreEqual(oneFeet, twelveInch);
        }

        /// <Test 2.1>
        /// Checking 3 Feet is equal to 1 Yard
        /// </Test2.1>
        [Test]
        public void CheckGivenThreeFeetIsEqualToOneYard()
        {
            double threeFeet = length.LengthConversion("FeetToYard",3.0);
            double oneYard = 1.0;
            Assert.AreEqual(oneYard,threeFeet);
        }

        /// <Test 2.2>
        /// Checking 1 Feet is not equal to 1 Yard
        /// </Test2.2>
        [Test]
        public void CheckGivenOneFeetIsNotEqualToOneYard()
        {
            double oneFeet = 1.0;
            double oneYard = length.LengthConversion("YardToFeet", 1.0);
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <Test 2.3>
        /// Checking 1 Inch is not equal to 1 Yard
        /// </Test2.3>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneYard()
        {
            double oneInch = 1.0;
            double oneYard = length.LengthConversion("InchToYard", 1.0);
            Assert.AreNotEqual(oneInch, oneYard);
        }

        /// <Test 2.4>
        /// Checking 1 Yard is equal to 36 Inch
        /// </Test2.4>
        [Test]
        public void CheckGivenOneYardIsEqualToThirtySixInch()
        {
            double thirtySixInch = 36.0;
            double oneYard = length.LengthConversion("YardToInch", 1.0);
            Assert.AreEqual(thirtySixInch, oneYard);
        }

        /// <Test 2.5>
        /// Checking 36 Inch is equal to 1 Yard
        /// </Test2.5>
        [Test]
        public void CheckGiventhirtySixInchIsEqualToOneYard()
        {
            double thirtySixInch = length.LengthConversion("InchToYard", 36.0);
            double oneYard = 1.0;
            Assert.AreEqual(oneYard,thirtySixInch);
        }

        /// <Test 2.6>
        /// Checking 1 Yard is equal to 3 Feet
        /// </Test2.6>
        [Test]
        public void CheckGivenOneYardIsEqualToThreeFeet()
        {
            double oneYard = length.LengthConversion("YardToFeet", 1.0);
            double threeFeet = 3.0;
            Assert.AreEqual(threeFeet, oneYard);
        }

        /// <Test 3.1>
        /// Checking 2 Inch is equal to 5 Centimetre
        /// </Test3.1>
        [Test]
        public void CheckGivenTwoInchIsEqualToFiveCentimeter()
        {
            double twoInch = length.LengthConversion("InchToCentimeter", 2.0);
            double fiveCentimeter = 5.0;
            Assert.AreEqual(fiveCentimeter, twoInch);
        }

        /// <Test 4.1>
        /// Checking 2 Inch addition to 2 Inch Equal to 4 inch
        /// </Test4.1>
        [Test]
        public void CheckGivenTwoLengthsInInchForAdditionReturnInInch()
        {
            double twoInch = length.AddTwoLenghtsInInch(Length.Unit.INCH,2,Length.Unit.INCH,2);
            double addTwoInch = 4.0;
            Assert.AreEqual(twoInch, addTwoInch);
        }

        /// <Test 4.2>
        /// Checking 1 Feet addition to 2 Inch Equal to 14 inch
        /// </Test4.2>
        [Test]
        public void CheckGivenTwoLengthsOneInFeetAndSecondInInchReturnInInch()
        {
            double oneFeetOneInch = length.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.INCH, 2);
            double addTwoInch = 14.0;
            Assert.AreEqual(addTwoInch, oneFeetOneInch);
        }

        /// <Test 4.3>
        /// Checking 1 Feet addition to 1 Feet Equal to 24 inch
        /// </Test4.3>
        [Test]
        public void CheckGivenTwoLengthsInFeetReturnInInch()
        {
            double addTwoFeet = length.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.FEET, 1);
            double addTwoInch = 24.0;
            Assert.AreEqual(addTwoInch, addTwoFeet);
        }

        /// <Test 4.4>
        /// Checking 2 Inch addition to 2.5 Centimeter Equal to 3 inch
        /// </Test4.4>
        [Test]
        public void CheckGivenTwoLengthsOneInInchSecondInCentimeterReturnInInch()
        {
            double oneInchOneCentimeter = length.AddTwoLenghtsInInch(Length.Unit.INCH, 2, Length.Unit.CENTIMETER, 2.5);
            double addTwoInch = 3.0;
            Assert.AreEqual(addTwoInch, oneInchOneCentimeter);
        }

        /// <Test 5.1>
        /// Checking 1 gallon is equal to 3.78 litres
        /// </Test5.1>
        [Test]
        public void CheckGivenOneGallonToLitre()
        {
            double oneGallon = volume.VolumeConversion("GallonToLitre",1.0);
            double oneGallonToLitre = 3.78;
            Assert.AreEqual(oneGallonToLitre, oneGallon);
        }

        /// <Test 5.2>
        /// Checking 1 litre is equal to 1000 Mililitres
        /// </Test5.2>
        [Test]
        public void CheckGivenOneLitreEqualToOneThousandMililitre()
        {
            double oneLitre = volume.VolumeConversion("LitreToMililitre", 1.0);
            double oneThousandMiliLitre = 1000;
            Assert.AreEqual(oneThousandMiliLitre, oneLitre);
        }

        /// <Test 6.1>
        /// Checking 1 gallon add to 3.78 litre is equal to 7.56 litres
        /// </Test6.1>
        [Test]
        public void CheckGivenOneGallonAndThreeLitreAddInLitre()
        {
            double oneGallonThreeLitre = volume.AddTwoVolumesInLitres(Volume.Unit.GALLON, 1.0,Volume.Unit.LITRE,3.78);
            double oneGallonAddToLitre = 7.56;
            Assert.AreEqual(oneGallonAddToLitre, oneGallonThreeLitre);
        }

        /// <Test 6.2>
        /// Checking 1 litre add to 1000 Mililitre is equal to 2 litres
        /// </Test6.2>
        [Test]
        public void CheckGivenOneLitreAndOneThousandMiliLitreAddInLitre()
        {
            double oneLitreOneThousandMiliLitre = volume.AddTwoVolumesInLitres(Volume.Unit.LITRE, 1.0, Volume.Unit.MILILITRE, 1000);
            double addInLitre = 2;
            Assert.AreEqual(addInLitre, oneLitreOneThousandMiliLitre);
        }

        /// <Test 7.1>
        /// Checking 1 Kilogram is equal to 1000 grams
        /// </Test7.1>
        [Test]
        public void CheckGivenOneKilogramIsEqualToOneThousandGrams()
        {
            double oneKilogramsInGrams = weight.WeightConversion("KilogramToGram", 1.0);
            double oneThousandGrams = 1000;
            Assert.AreEqual(oneThousandGrams, oneKilogramsInGrams);
        }

        /// <Test 7.2>
        /// Checking 1 Tonne is equal to 1000 Kilograms
        /// </Test7.2>
        [Test]
        public void CheckGivenOneTonneIsEqualToOneThousandKilogram()
        {
            double oneTonneInKilograms = weight.WeightConversion("TonneToKilogram", 1.0);
            double oneThousandKiloGrams = 1000;
            Assert.AreEqual(oneThousandKiloGrams, oneTonneInKilograms);
        }
    }
}