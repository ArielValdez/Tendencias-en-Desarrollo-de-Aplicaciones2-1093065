using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Dia2
{
    public class Temperature
    {
        public float Degree { get; set; }
        public int Scale { get; set; }
        public Temperature()
        {

        }
        public Temperature(float degree, TemperatureScale scale)
        {
            this.Degree = degree;
            this.Scale = (int)scale;
        }
        #region basic calculations
        public float Add(Temperature n)
        {
            float result = 0f;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree + n.Degree;
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree + this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree + this.KelvinToCelsius(n);
                    }
                    else return 0;
                    break;
                case 1: //Kelvin
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree + this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree - n.Degree;
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree + this.FarenheitToKelvin(n);
                    }
                    else return 0;
                    break;
                case 2: //Farenheit
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree + this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree + this.KelvinToFarenheit(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree + n.Degree;
                    }
                    else return 0;
                    break;
                default:
                    //Do something!!!
                    break;
            }
            return this.Truncate(result, 2);
        }
        public float Substract(Temperature n)
        {
            float result = 0f;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree - n.Degree;
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree - this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree - this.KelvinToCelsius(n);
                    }
                    else return 0;
                    break;
                case 1: //Kelvin
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree - this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree - n.Degree;
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree - this.FarenheitToKelvin(n);
                    }
                    else return 0;
                    break;
                case 2: //Farenheit
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree - this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree - this.KelvinToFarenheit(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree - n.Degree;
                    }
                    else return 0;
                    break;
                default:
                    //Do something!!!
                    break;
            }
            return this.Truncate(result, 2);
        }
        public float Multiply(Temperature n)
        {
            float result = 0f;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree * n.Degree;
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree * this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree * this.KelvinToCelsius(n);
                    }
                    else return 0;
                    break;
                case 1: //Kelvin
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree * this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree * n.Degree;
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree * this.FarenheitToKelvin(n);
                    }
                    else return 0;
                    break;
                case 2: //Farenheit
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree * this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree * this.KelvinToFarenheit(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree * n.Degree;
                    }
                    else return 0;
                    break;
                default:
                    //Do something!!!
                    break;
            }
            return this.Truncate(result, 2);
        }
        public float Divide(Temperature n)
        {
            float result = 0f;
            switch (this.Scale)
            {
                case 0: //Celsius
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree / n.Degree;
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree / this.FarenheitToCelsius(n);
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree / this.KelvinToCelsius(n);
                    }
                    else return 0;
                    break;
                case 1: //Kelvin
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree / this.CelsiusToKelvin(n);
                    }
                    else if (n.Scale == 1) //Farenheits Case
                    {
                        result = this.Degree / n.Degree;
                    }
                    else if (n.Scale == 2) //Kelvins case
                    {
                        result = this.Degree / this.FarenheitToKelvin(n);
                    }
                    else return 0;
                    break;
                case 2: //Farenheit
                    if (n.Scale == 0) //Celsiuss Case
                    {
                        result = this.Degree / this.CelsiusToFarenheit(n);
                    }
                    else if (n.Scale == 1) //Kelvin Case
                    {
                        result = this.Degree / this.KelvinToFarenheit(n);
                    }
                    else if (n.Scale == 2) //Faren case
                    {
                        result = this.Degree / n.Degree;
                    }
                    else return 0;
                    break;
                default:
                    //Do something!!!
                    break;
            }
            return this.Truncate(result, 2);
        }
        #endregion

        #region conversion methods
        //Method from: https://social.msdn.microsoft.com/Forums/en-US/a8092fd2-1080-416c-8ae1-2bad8c013a21/how-to-round-off-a-float-to-2-decimal-places?forum=csharpgeneral
        private float Truncate(float value, int digits)
        {
            double mult = Math.Pow(10.0, digits);
            double result = Math.Truncate(mult * value) / mult;
            return (float)result;
        }

        public float CelsiusToFarenheit(Temperature n)
        {
            //(0°C × 9/5) + 32 = 32°F
            if (n.Scale == 0)
            {
                float celsius = n.Degree;
                float farenheit = (celsius * 9f/5f) + 32;
                return farenheit;
            } else return 0;
        }
        public float FarenheitToCelsius(Temperature n)
        {
            // (0°F − 32) × 5/9 = -17.7778°C
            if (n.Scale == 2)
            {
                float farenheit = n.Degree;
                float celsius = (farenheit - 32) * 5f/9f;
                return celsius;
            }
            else return 0;
        }
        public float CelsiusToKelvin(Temperature n)
        {
            // 0°C + 273 = 273K
            if (n.Scale == 0)
            {
                float celsius = n.Degree;
                float kelvin = celsius + 273f;
                return kelvin;
            }
            else return 0;
        }
        public float KelvinToCelsius(Temperature n)
        {
            //0K − 273 = -273°C
            if (n.Scale == 1)
            {
                float kelvin = n.Degree;
                float celsius = kelvin - 273f;
                return celsius;
            }
            else return 0;
        }
        public float FarenheitToKelvin(Temperature n)
        {
            //(0°F − 32) × 5/9 + 273.15 = 255.372K
            if (n.Scale == 2)
            {
                float farenheitToCelsius = this.FarenheitToCelsius(n);
                float kelvin = farenheitToCelsius + 273;
                return kelvin;
            }
            else return 0;
        }
        public float KelvinToFarenheit(Temperature n)
        {
            //(0K − 273.15) × 9/5 + 32 = -459.7°F
            if (n.Scale == 1)
            {
                float kelvinToCelsius = this.KelvinToCelsius(n);
                float farenheit = kelvinToCelsius * 9f/5f + 32;
                return farenheit;
            }
            else return 0;
        }
        #endregion
    }
}
