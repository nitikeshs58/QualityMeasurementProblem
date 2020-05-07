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
            INCH
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
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value) ||
                 (this.unit.Equals(Unit.FEET) && ((Length)obj).unit.Equals(Unit.INCH) &&
                this.value == 0 && ((Length)obj).value == 0);
        }

        public double FeetToInch(double valueInFeet)
        {
            return valueInFeet * 12;
        }

        public double InchToFeet(double valueInInch)
        {
            return valueInInch / 12;
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
