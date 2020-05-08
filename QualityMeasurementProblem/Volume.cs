using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProblem
{
    public class Volume
    {
        // Variables
        Unit unit;
        private double value;

        public enum Unit
        {
            GALLON,
            LITRE,
            MILILITRE
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
        public double VolumeConversion(string conversion, double givenValue)
        {
            switch (conversion)
            {
                case "GallonToLitre":
                    double gallonToLitre = givenValue * 3.78;
                    return gallonToLitre;
                case "LitreToMililitre":
                    double litreToMililitre = givenValue * 1000;
                    return litreToMililitre;
                case "MililitreToLitre":
                    double mililitreToLitre = givenValue / 1000;
                    return mililitreToLitre;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }

        /// <summary>
        /// Adding two vloumes in litres
        /// if its unit is not in litre then we are converting it in liters
        /// and making addition of it.
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoVolumesInLitres(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInLitre = valueOne;
            double secondValueInLitre = valueTwo;
           
            if (unitOne == Unit.GALLON)
            {
                firstValueInLitre = VolumeConversion("GallonToLitre", valueOne);
            }
            else if (unitTwo == Unit.MILILITRE)
            {
                secondValueInLitre = VolumeConversion("MililitreToLitre", valueTwo);
            }
            return firstValueInLitre + secondValueInLitre;
        }
    }
}
