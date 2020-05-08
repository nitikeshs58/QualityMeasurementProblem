///--------------------------------------------------------------------
///   Class:       Length
///   Description: There are two methods in Length class 
///                1) Equals
///                2) LengthConversion
///   Author:      Nitikesh Shinde                   Date: 08/05/2020
///--------------------------------------------------------------------

using System;

namespace QualityMeasurementProblem
{
    public class Length
    {
        //Variables
        Unit unit;
        private double value;

        // enum method for Unit
        public enum Unit
        {
            FEET,
            INCH,
            CENTIMETER,
            FEET_TO_INCH,
            INCH_TO_FEET,
            FEET_TO_YARD,
            YARD_TO_FEET,
            INCH_TO_YARD,
            YARD_TO_INCH,
            INCH_TO_CENTIMETER,
            CENTIMETER_TO_INCH
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
            // If Object is Null It Will Return False.
            if (obj == null)
                return false;
            // If obj is equal to this , It will return True
            if (obj == this)
                return true;
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value);
        }

        /// <summary>
        /// By using Switch case we are checking type of conversion
        /// and doing calculation
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double LengthConversion(Unit unit,double givenValue)
        {
            switch (unit)
            {
                case Unit.FEET_TO_INCH:
                    double feetToInch= givenValue * 12;
                    return feetToInch;
                case Unit.INCH_TO_FEET:
                    double inchToFeet = givenValue / 12;
                    return inchToFeet;
                case Unit.FEET_TO_YARD:
                    double feetToyard = givenValue / 3;
                    return feetToyard;
                case Unit.YARD_TO_FEET:
                    double yardToFeet = givenValue * 3;
                    return yardToFeet;
                case Unit.INCH_TO_YARD:
                    double inchToYard = givenValue / 36;
                    return inchToYard;
                case Unit.YARD_TO_INCH:
                    double yardToInch = givenValue * 36;
                    return yardToInch;
                case Unit.INCH_TO_CENTIMETER:
                    double inchToCentimeter = givenValue * 2.5;
                    return inchToCentimeter;
                case Unit.CENTIMETER_TO_INCH:
                    double centimeterToInch = givenValue / 2.5;
                    return centimeterToInch;
                default:
                    return givenValue;
            }
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
