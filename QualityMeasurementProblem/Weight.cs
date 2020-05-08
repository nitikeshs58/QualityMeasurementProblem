///--------------------------------------------------------------------
///   Class:       Weight
///   Description: Contains one Methods
///                 1) WeightConversion
///   Author:      Nitikesh Shinde                   Date: 08/05/2020
///--------------------------------------------------------------------

using System;

namespace QualityMeasurementProblem
{
    public class Weight
    {
        // Variables
        Unit unit;
        private double value;

        public enum Unit
        {
            KILOGRAM,
            GRAMS,
            TONNE,
            TONNE_TO_KILOGRAM,
            GRAM_TO_KILOGRAM,
            KILOGRAM_TO_GRAM
        };

        // Default Constructor
        public Weight()
        { }

        // Parameterised COnstructor
        public Weight(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Weight Conversion Logic part
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double WeightConversion(Unit unit, double givenValue)
        {
            switch (unit)
            {
                case Unit.KILOGRAM_TO_GRAM:
                    double kilogramToGram = givenValue * 1000;
                    return kilogramToGram;
                case Unit.GRAM_TO_KILOGRAM:
                    double gramToKilogram = givenValue / 1000;
                    return gramToKilogram;
                case Unit.TONNE_TO_KILOGRAM:
                    double tonneToKilogram = givenValue * 1000;
                    return tonneToKilogram;
                default:
                    return givenValue;
            }
        }
    }
}
