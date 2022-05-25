using System;

namespace Temperatura_Dia3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Add your first temperature: ");
                float aTemp = float.Parse(Console.ReadLine());
                Console.Write("\nAdd your scale (Celsius = 0 | Farenheit = 1 | Kelvin = 2): ");
                byte aScale = byte.Parse(Console.ReadLine());

                Console.Write("\nAdd your second temperature: ");
                float bTemp = float.Parse(Console.ReadLine());
                Console.Write("\nAdd your scale (Celsius = 0 | Farenheit = 1 | Kelvin = 2): ");
                byte bScale = byte.Parse(Console.ReadLine());

                Temperature a = new(aTemp, aScale);
                Temperature b = new(bTemp, bScale);

                var chosenScaleA = Enum.GetName(typeof(TemperatureScale), aScale);
                var chosenScaleB = Enum.GetName(typeof(TemperatureScale), bScale);

                Console.Clear();

                if (!(aScale < 0 || bScale < 0 || aScale > 2 || bScale > 2))
                {
                    Console.WriteLine("The input temperatures are: ");
                    Console.WriteLine("a: {0}\t{1}\nb: {2}\t{3}", aTemp, chosenScaleA, bTemp, chosenScaleB);
                    Console.WriteLine("----------------------------\nBasic Calculations");
                    Console.WriteLine("{0} {1} + {2} {3} = {4} {5}", 
                        a.Degree, chosenScaleA, b.Degree, chosenScaleB, a.Add(b), chosenScaleA);
                    Console.WriteLine("{0} {1} - {2} {3} = {4} {5}",
                        a.Degree, chosenScaleA, b.Degree, chosenScaleB, a.Substract(b), chosenScaleA);
                    Console.WriteLine("{0} {1} * {2} {3} = {4} {5}",
                        a.Degree, chosenScaleA, b.Degree, chosenScaleB, a.Multiply(b), chosenScaleA);
                    Console.WriteLine("{0} {1} / {2} {3} = {4} {5}",
                        a.Degree, chosenScaleA, b.Degree, chosenScaleB, a.Divide(b), chosenScaleA);
                }
                else
                {
                    Console.WriteLine("The scales should be the following: Celsius = 0 | Farenheit = 1 | Kelvin = 2 for any scale added \nPress any key to close program");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
