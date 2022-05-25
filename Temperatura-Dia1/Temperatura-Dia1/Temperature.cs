using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Dia1
{
    public enum TemperatureScale
    {
        Celsius, //0
        Kelvin, //1
        Farenheit //2
    }

    public class Temperature
    {
        private float Degree { get; set; }
        private int Scale { get; set; }
        //private float Result;
        public Temperature()
        {

        }
        public Temperature(float degree, TemperatureScale temperatureScale)
        {
            this.Degree = degree;
            this.Scale = (int)temperatureScale;
        }

        //The following methods should return the temperature with the scale of the left
        //i.e.: let a -> Kelvin, let b -> Celsius: a.add(b) = c K
        #region basic calculations
        public float Add(Temperature n)
        {
            float result = 0;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree + n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree + this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree + this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 1: //Farenheit
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree + this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree + n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        // (0K − 273.15) × 9/5 + 32
                        float conversion = this.KelvinToCelsius(n) * (9/5) + 32;
                        result = this.Degree + conversion;
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 2: //Kelvin
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree + this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        //Farenheit to Kelvin
                        //(0°F − 32) × 5/9 + 273.15
                        float conversion = this.FarenheitToCelsius(n) + 273.15f;
                        result = this.Degree + conversion;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree + this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                default:
                    //Hello World!
                    break;
            }
            return result;
        }
        public float Substract(Temperature n)
        {
            float result = 0;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree - n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree - this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree - this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 1: //Farenheit
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree - this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree - n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        // (0K − 273.15) × 9/5 + 32
                        float conversion = this.KelvinToCelsius(n) * (9 / 5) + 32;
                        result = this.Degree - conversion;
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 2: //Kelvin
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree - this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        //Farenheit to Kelvin
                        //(0°F − 32) × 5/9 + 273.15
                        float conversion = this.FarenheitToCelsius(n) + 273.15f;
                        result = this.Degree - conversion;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree - this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                default:
                    //Hello World!
                    break;
            }
            return result;
        }
        public float Multiply(Temperature n)
        {
            float result = 0;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree * n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree * this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree * this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 1: //Farenheit
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree * this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree * n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        // (0K − 273.15) × 9/5 + 32
                        float conversion = this.KelvinToCelsius(n) * (9 / 5) + 32;
                        result = this.Degree * conversion;
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 2: //Kelvin
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree * this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        //Farenheit to Kelvin
                        //(0°F − 32) × 5/9 + 273.15
                        float conversion = this.FarenheitToCelsius(n) + 273.15f;
                        result = this.Degree * conversion;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree * this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                default:
                    //Hello World!
                    break;
            }
            return result;
        }
        public float Divide(Temperature n)
        {
            float result = 0;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree / n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree / this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree / this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 1: //Farenheit
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree / this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        result = this.Degree / n.Degree;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        // (0K − 273.15) × 9/5 + 32
                        float conversion = this.KelvinToCelsius(n) * (9 / 5) + 32;
                        result = this.Degree / conversion;
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                case 2: //Kelvin
                    if (n.Scale == (int)TemperatureScale.Celsius)
                    {
                        result = this.Degree / this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == (int)TemperatureScale.Farenheit)
                    {
                        //Farenheit to Kelvin
                        //(0°F − 32) × 5/9 + 273.15
                        float conversion = this.FarenheitToCelsius(n) + 273.15f;
                        result = this.Degree / conversion;
                    }
                    else if (n.Scale == (int)TemperatureScale.Kelvin)
                    {
                        result = this.Degree / this.KelvinToCelsius(n);
                    }
                    else
                    {
                        //there are only 3 scales
                        return 0;
                    }
                    break;
                default:
                    //Hello World!
                    break;
            }
            return result;
        }
        #endregion

        #region scale conversion
        //Celsius to Farenheit
        private float CelsiusToFarenheit(Temperature n) //should return temperature instead?
        {
            // (0°C × 9/5) + 32 = °F
            if (n.Scale == (int)TemperatureScale.Celsius)
            {
                float celsius = n.Degree;
                float farenheit = (9f / 5f * celsius) + 32;
                return farenheit;
            }
            else
            {
                return 0;
            }
        }

        //Farenheit to Celsius
        private float FarenheitToCelsius(Temperature n) //should return temperature instead?
        {
            // (0°F − 32) × 5/9 = °C
            if (n.Scale == (int)TemperatureScale.Farenheit)
            {
                float farenheit = n.Degree;
                float celsius = (farenheit - 32) * (5f / 9f);
                return celsius;
            }
            else
            {
                return 0;
            }
        }
        //Kelvin to Celsius
        private float KelvinToCelsius(Temperature n)
        {
            //0K − 273.15 = °C
            if (n.Scale == (int)TemperatureScale.Kelvin)
            {
                float kelvin = n.Degree;
                float celsius = kelvin - 273.15f;
                return celsius;
            }
            else
            {
                return 0;
            }
        }
        //Celsius to Kelvin
        private float CelsiusToKelvin(Temperature n)
        {
            // 0°C + 273.15 = K
            if (n.Scale == (int)TemperatureScale.Celsius)
            {
                float celsius = n.Degree;
                float kelvin = celsius + 273.15f;
                return kelvin;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
