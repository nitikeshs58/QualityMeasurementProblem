using System;
using System.Collections.Generic;
using System.Text;

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
            TONNE
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
        public double WeightConversion(string conversion, double givenValue)
        {
            switch (conversion)
            {
                case "KilogramToGram":
                    double kilogramToGram = givenValue * 1000;
                    return kilogramToGram;
                case "GramToKilogram":
                    double gramToKilogram = givenValue / 1000;
                    return gramToKilogram;
                case "TonneToKilogram":
                    double tonneToKilogram = givenValue * 1000;
                    return tonneToKilogram;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }

        /// <summary>
        /// Adding two weights in grams
        /// if its unit is not in gram then we are converting it in grams
        /// and making addition of it.
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoWeightInGrams(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInLitre = valueOne;
            double secondValueInLitre = valueTwo;

            if (unitOne == Unit.TONNE)
            {
                firstValueInLitre = WeightConversion("TonneToKilogram", valueOne);
            }
            else if (unitTwo == Unit.GRAMS)
            {
                secondValueInLitre = WeightConversion("GramToKilogram", valueTwo);
            }
            return firstValueInLitre + secondValueInLitre;
        }
    }
}
