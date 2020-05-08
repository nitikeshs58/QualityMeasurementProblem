///--------------------------------------------------------------------
///   Class:       Volume
///   Description: Contains a Methods
///                 1) VolumeConversion
///   Author:      Nitikesh Shinde                   Date: 08/05/2020
///--------------------------------------------------------------------

using System;

namespace QualityMeasurementProblem
{
    public class Volume
    {
        // Variables
        Unit unit;
        private double value;

        public enum Unit
        {
            LITRE,
            MILILITRE,
            GALLON,
            MILILITRE_TO_LITRE,
            LITRE_TO_MILILITRE,
            GALLON_TO_LITRE
        };

        // Default Constructor
        public Volume()
        { }

        // Parameterised COnstructor
        public Volume(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Volume Conversion Logic part
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double VolumeConversion(Unit unit, double givenValue)
        {
            switch (unit)
            {
                case Unit.GALLON_TO_LITRE:
                    double gallonToLitre = givenValue * 3.78;
                    return gallonToLitre;
                case Unit.LITRE_TO_MILILITRE:
                    double litreToMililitre = givenValue * 1000;
                    return litreToMililitre;
                case Unit.MILILITRE_TO_LITRE:
                    double mililitreToLitre = givenValue / 1000;
                    return mililitreToLitre;
                default:
                    return givenValue;
            }
        }
    }
}
