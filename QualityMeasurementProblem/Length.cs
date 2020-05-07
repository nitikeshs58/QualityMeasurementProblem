using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProblem
{
    public class Length
    {
        //Variables
        Unit unit;
        private double value;

        public enum Unit
        {
            FEET,
            INCH,
            CENTIMETER
        };

        // Default Constructor
        public Length()
        { }

        // Parameterised COnstructor
        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If Object is Null It Will Return False.
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value);
        }

        /// <summary>
        /// By using Switch case we are checking type of converson
        /// and doing calculation
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double LengthConversion(string conversion,double givenValue)
        {
            switch (conversion)
            {
                case "FeetToInch":
                    double feetToInch= givenValue * 12;
                    return feetToInch;
                case "InchToFeet":
                    double inchToFeet = givenValue / 12;
                    return inchToFeet;
                case "FeetToYard":
                    double feetToyard = givenValue / 3;
                    return feetToyard;
                case "YardToFeet":
                    double yardToFeet = givenValue * 3;
                    return yardToFeet;
                case "InchToYard":
                    double inchToYard = givenValue / 36;
                    return inchToYard;
                case "YardToInch":
                    double yardToInch = givenValue * 36;
                    return yardToInch;
                case "InchToCentimeter":
                    double inchToCentimeter = givenValue * 2.5;
                    return inchToCentimeter;
                case "CentimeterToInch":
                    double centimeterToInch = givenValue / 2.5;
                    return centimeterToInch;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }

        public double AddTwoLenghtsInInch(Unit unitOne,double valueOne,Unit unitTwo,double valueTwo)
        {
            double firstValueInInch = valueOne;
            double secondValueInInch = valueTwo;
            //
            if (unitOne == Unit.INCH && unitTwo == Unit.INCH)
                return firstValueInInch + secondValueInInch;
            if (unitOne == Unit.FEET) 
            {
                firstValueInInch = LengthConversion("FeetToInch", valueOne);
            }
            else if(unitOne==Unit.CENTIMETER)
            {
                firstValueInInch = LengthConversion("CentimeterToInch", valueOne);
            }

            if (unitTwo == Unit.FEET)
            {
                secondValueInInch = LengthConversion("FeetToInch", valueTwo);
            }
            else if (unitTwo == Unit.CENTIMETER)
            {
                secondValueInInch = LengthConversion("CentimeterToInch", valueTwo);
            }
            return firstValueInInch+ secondValueInInch;
        }
        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
