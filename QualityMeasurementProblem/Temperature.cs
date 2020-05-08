///--------------------------------------------------------------------
///   Class:       Temperature
///   Description: Contains Temperature Conversion method
///   Author:      Nitikesh Shinde                   Date: 08/05/2020
///--------------------------------------------------------------------

using System;

namespace QualityMeasurementProblem
{
    public class Temperature
    {
        public enum Unit
        {
            FAHRENHIET,
            CELSIUS,
        };

        /// <summary>
        /// Temperature Conversion
        /// Fahrenhite to Celsius and Celsius to fahrenhite
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double TemperatureConversion(string conversion,double givenValue)
        {
            switch(conversion)
            {
                case "FahrenhiteToCelsius":
                    return (givenValue - 32) * 5/9;
                case "CelsiusToFahrenhiet":
                    return (givenValue * 9 / 5) + 32;
                default:
                    Console.WriteLine("Invalid Conversion type!");
                    break;
            }
            return 0;            
        }
    }
}
