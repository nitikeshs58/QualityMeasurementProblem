using NUnit.Framework;
using QualityMeasurementProblem;
namespace QualityTest
{
    public class Tests
    {
        //Object Creation
        readonly Length lengthConversion = new Length();

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
            double zeroFeet = lengthConversion.LengthConversion("FeetToInch",0.0);
            double zeroInch = lengthConversion.LengthConversion("InchToFeet",0.0);
            Assert.AreEqual(zeroFeet, zeroInch);
        }

        /// <Test 1.12>
        /// Checking 1 feet is not equal to 1 inch
        /// </Test1.12>
        [Test]
        public void CheckGivenOneFeetIsNotEqualToOneInch()
        {
            double oneFeet = lengthConversion.LengthConversion("FeetToInch",1.0);
            double oneInch = lengthConversion.LengthConversion("InchToFee", 1.0);
            Assert.AreNotEqual(oneFeet, oneInch);
        }

        /// <Test 1.13>
        /// Checking 1 Inch is not equal to 1 Foot
        /// </Test1.13>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneFeet()
        {
            double oneInch = lengthConversion.LengthConversion("InchToFeet",1.0);
            double oneFeet = lengthConversion.LengthConversion("FeetToInch", 1.0);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <Test 1.14>
        /// Checking 1 Feet is equal to 12 Inch
        /// </Test1.14>
        [Test]
        public void CheckGivenOneFeetIsEqualToTwelveInch()
        {
            double oneFeet = lengthConversion.LengthConversion("FeetToInch", 1.0);
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
            double twelveInch = lengthConversion.LengthConversion("InchToFeet",12.0);
            Assert.AreEqual(oneFeet, twelveInch);
        }

        /// <Test 2.1>
        /// Checking 3 Feet is equal to 1 Yard
        /// </Test2.1>
        [Test]
        public void CheckGivenThreeFeetIsEqualToOneYard()
        {
            double threeFeet = lengthConversion.LengthConversion("FeetToYard",3.0);
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
            double oneYard = lengthConversion.LengthConversion("YardToFeet", 1.0);
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <Test 2.3>
        /// Checking 1 Inch is not equal to 1 Yard
        /// </Test2.3>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneYard()
        {
            double oneInch = 1.0;
            double oneYard = lengthConversion.LengthConversion("InchToYard", 1.0);
            Assert.AreNotEqual(oneInch, oneYard);
        }

        /// <Test 2.4>
        /// Checking 1 Yard is equal to 36 Inch
        /// </Test2.4>
        [Test]
        public void CheckGivenOneYardIsEqualToThirtySixInch()
        {
            double thirtySixInch = 36.0;
            double oneYard = lengthConversion.LengthConversion("YardToInch", 1.0);
            Assert.AreEqual(thirtySixInch, oneYard);
        }
    }
}