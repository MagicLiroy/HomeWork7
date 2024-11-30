using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static double GetSquare (double a)
        {
            return 6 * a * a * a;
        }

        static double GetVolume (double a)
        {
            return a * a * a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение ребра куба: ");
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine("Объем куба: {0:.00}, площадь куба: {1:.00}", GetSquare(side), GetVolume(side));
        }
    }
}
