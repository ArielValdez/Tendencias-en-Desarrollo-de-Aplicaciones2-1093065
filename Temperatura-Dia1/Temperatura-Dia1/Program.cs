using System;

namespace Temperatura_Dia1
{
    class Program
    {
        static void Main(string[] args) //Necesario crear elementos para redondeo
        {
            //The program will close once the tasks has been completed
            try
            {
                // the program
                Console.WriteLine("Add a temperature for A: ");
                float tempA = float.Parse(Console.ReadLine());
                Console.WriteLine("Add a scale for A (0 for Celsius | 1 for Kelvin | 2 for Farenheit): \n");
                int scaleA = int.Parse(Console.ReadLine());

                Console.WriteLine("Add a temperature for B: ");
                float tempB = float.Parse(Console.ReadLine());
                Console.WriteLine("Add a scale for A (0 for Celsius | 1 for Kelvin | 2 for Farenheit): \n");
                int scaleB = int.Parse(Console.ReadLine());

                if ((scaleA > 2 && scaleB > 2) || (scaleA < 0 && scaleB < 0))
                {
                    Console.WriteLine("Scales should be between the range given");
                }
                else
                {
                    var a = new Temperature(tempA, (TemperatureScale)scaleA);
                    var b = new Temperature(tempB, (TemperatureScale)scaleB);

                    Console.WriteLine("a + b = {0}", a.Add(b));
                    Console.WriteLine("a - b = {0}", a.Substract(b));
                    Console.WriteLine("a * b = {0}", a.Multiply(b));
                    Console.WriteLine("a / b = {0}", a.Divide(b));
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
