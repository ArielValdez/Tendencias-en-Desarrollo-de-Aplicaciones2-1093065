using System;

namespace Temperatura_Dia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = new Temperature();
            //Console.WriteLine(x.Truncate(1.3454343446f, 2));
            try
            {
                Console.Write("Add your degree for your first temperature: ");
                float aDegree = float.Parse(Console.ReadLine());
                Console.WriteLine("Add your scale (0 = Celsius | 1 = Kelvin | 2 = Farenheit)");
                Console.WriteLine("Your scale must not be above 2 or below 0!");
                int aScale = int.Parse(Console.ReadLine());

                Console.Write("Add your degree for your second temperature: ");
                float bDegree = float.Parse(Console.ReadLine());
                Console.WriteLine("Add your scale in number (0 = Celsius | 1 = Kelvin | 2 = Farenheit)");
                Console.Write("Your scale must not be above 2 or below 0! \n Scale: ");
                int bScale = int.Parse(Console.ReadLine());

                Console.Clear();

                if ((aScale > 2 || bScale > 2) || (aScale < 0 || bScale < 0))
                {
                    Console.WriteLine("Scales in numbers must be the following: (0 for Celsius | 1 for Kelvin | 2 for Farenheit)");
                }
                else
                {
                    var a = new Temperature(aDegree, (TemperatureScale)aScale);
                    var b = new Temperature(bDegree, (TemperatureScale)bScale);

                    Console.WriteLine("{0} {1} + {2} {3} = {4}", a.Degree, a.Scale, b.Degree, b.Scale, a.Add(b));
                    Console.WriteLine("{0} {1} - {2} {3} = {4}", a.Degree, a.Scale, b.Degree, b.Scale, a.Substract(b));
                    Console.WriteLine("{0} {1} x {2} {3} = {4}", a.Degree, a.Scale, b.Degree, b.Scale, a.Multiply(b));
                    Console.WriteLine("{0} {1} / {2} {3} = {4}", a.Degree, a.Scale, b.Degree, b.Scale, a.Divide(b));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
