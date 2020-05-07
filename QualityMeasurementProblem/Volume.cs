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
            LITRE
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
        public double volumeConversion(string conversion, double givenValue)
        {
            switch (conversion)
            {
                case "GallonToLitre":
                    double gallonToLitre = givenValue * 3.78;
                    return gallonToLitre;
                case "LitreToMililitre":
                    double litreToMililitre = givenValue * 1000;
                    return litreToMililitre;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
    }
}
