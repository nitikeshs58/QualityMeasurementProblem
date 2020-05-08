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
            FAHRENHIET_TO_CELSIUS,
            CELSIUS_TO_FAHRENHITE
        };

        /// <summary>
        /// Temperature Conversion
        /// Fahrenhite to Celsius and Celsius to fahrenhite
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double TemperatureConversion(Unit unit,double givenValue)
        {
            switch(unit)
            {
                case Unit.FAHRENHIET_TO_CELSIUS:
                    return (givenValue - 32) * 5/9;
                case Unit.CELSIUS_TO_FAHRENHITE:
                    return (givenValue * 9 / 5) + 32;
                default:
                    Console.WriteLine("Invalid Conversion type!");
                    break;
            }
            return 0;            
        }
    }
}
