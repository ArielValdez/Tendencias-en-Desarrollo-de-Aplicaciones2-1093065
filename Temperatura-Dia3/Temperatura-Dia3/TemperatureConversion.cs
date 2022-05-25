using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Dia3
{
    public class TemperatureConversion
    {
        //Methods for conversion
        #region convesion
        //Celsius a Farenheit: (0°C × 9/5) + 32 = 32°F

        // C = Celsius | Farenheit = F | K = Kelvin
        public float C2F(Temperature n)
        {
            //Calculate Celsius to farenheit
            try
            {
                if (n.Scale == TemperatureScale.Celsius)
                {
                    float celsius = n.Degree;
                    float result = (celsius * 9f / 5f) + 32f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {
                //Error
                return 0;
            }            
        }
        public float F2C(Temperature n)
        {
            //Calculate farenheit to celsius
            //Farenheit a Celsius: (0°F − 32) × 5/9 = -17.7778°C
            try
            {
                if (n.Scale == TemperatureScale.Farenheit)
                {
                    float farenheit = n.Degree;
                    float result = (farenheit - 32f) * 5f / 9f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public float K2C(Temperature n)
        {
            //Calculate kelvin to celsius
            //Kelvin a Celsius: 0K − 273.15 = -275.15°C
            try
            {
                if (n.Scale == TemperatureScale.Kelvin)
                {
                    float kelvin = n.Degree;
                    float result = kelvin - 273f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public float C2K(Temperature n)
        {
            //Calculate celsius to kelvin
            //Celsius a Kelvin: 0°C + 273.15 = 273.15K
            try
            {
                if (n.Scale == TemperatureScale.Celsius)
                {
                    float celsius = n.Degree;
                    float result = celsius + 273f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public float K2F(Temperature n)
        {
            //Calculate Kelvin to farenheit
            //Kelvin a Farenheit: (0K − 273.15) × 9/5 + 32 = -459.7°F
            try
            {
                if (n.Scale == TemperatureScale.Kelvin)
                {
                    float kelvin = n.Degree;
                    float result = (kelvin - 273f) * 9f / 5f + 32f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public float F2K(Temperature n)
        {
            //Calculate Farenheit to Kelvin
            //Farenheit a Kelvin: (0°F − 32) × 5/9 + 273.15 = 255.372K
            try
            {
                if (n.Scale == TemperatureScale.Farenheit)
                {
                    float farenheit = n.Degree;
                    float result = (farenheit - 32f) * 5f / 9f + 273f;
                    return result;
                }
                else return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        #endregion
    }
}
