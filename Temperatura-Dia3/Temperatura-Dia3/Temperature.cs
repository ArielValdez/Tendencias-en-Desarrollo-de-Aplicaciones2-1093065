using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Dia3
{
    public class Temperature : TemperatureConversion
    {
        public float Degree { get; set; }
        public TemperatureScale Scale { get; set; }
        public Temperature()
        {

        }

        public Temperature(float degree, byte scale)
        {
            this.Degree = degree;
            this.Scale = (TemperatureScale)scale; //This should not allow number above 2 or below 0
        }

        //Basic calculations methods
        #region basic calculations
        public float Add(Temperature n)
        {
            switch (this.Scale)
            {
                case TemperatureScale.Celsius:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree + n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree + C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree + K2C(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Farenheit:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree + C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree + n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree + K2F(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Kelvin:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree + C2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree + F2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree + n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                default:
                    //DO SOMETHING!!!
                    break;
            }
            return 0;
        }
        public float Substract(Temperature n)
        {
            switch (this.Scale)
            {
                case TemperatureScale.Celsius:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree - n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree - C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree - K2C(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Farenheit:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree - C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree - n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree - K2F(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Kelvin:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree - C2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree - F2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree - n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                default:
                    //DO SOMETHING!!!
                    break;
            }
            return 0;
        }
        public float Multiply(Temperature n)
        {
            switch (this.Scale)
            {
                case TemperatureScale.Celsius:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree * n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree * C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree * K2C(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Farenheit:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree * C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree * n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree * K2F(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Kelvin:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree * C2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree * F2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree * n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                default:
                    //DO SOMETHING!!!
                    break;
            }
            return 0;
        }
        public float Divide(Temperature n)
        {
            switch (this.Scale)
            {
                case TemperatureScale.Celsius:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree / n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree / C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree / K2C(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Farenheit:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree / C2F(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree / n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree / K2F(n);
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                case TemperatureScale.Kelvin:
                    if (n.Scale == TemperatureScale.Celsius)
                    {
                        float result = this.Degree / C2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Farenheit)
                    {
                        float result = this.Degree / F2K(n);
                        return this.Truncate(result, 2);
                    }
                    else if (n.Scale == TemperatureScale.Kelvin)
                    {
                        float result = this.Degree / n.Degree;
                        return this.Truncate(result, 2);
                    }
                    else return 0f;
                default:
                    //DO SOMETHING!!!
                    break;
            }
            return 0;
        }
        #endregion
        private float Truncate(float value, int digits)
        {
            double m = Math.Pow(10.0, digits);
            double result = Math.Truncate(m * value) / m;
            return (float)result;
        }
    }
}
