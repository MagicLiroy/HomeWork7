using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        static double GetSquare(double[] a)
        {
            double halfPerimeter = (a[0] + a[1] + a[2]) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a[0]) * (halfPerimeter - a[1]) * (halfPerimeter - a[2]));
        }

        static void Main(string[] args)
        {
            double[] side = new double[3] { 0, 0, 0 };

            for (int i = 0; i < side.Length; i++)
            {
                Console.WriteLine($"Укажите {i + 1}-ю сторону первого треугольника: ");
                side[i] = double.Parse(Console.ReadLine());
            }

            double firstTriangle = GetSquare(side);

            for (int i = 0; i < side.Length; i++)
            {
                Console.WriteLine($"Укажите {i + 1}-ю сторону второго треугольника: ");
                side[i] = double.Parse(Console.ReadLine());
            }

            double secondTriangle = GetSquare(side);

            if (firstTriangle > secondTriangle)
            {
                Console.WriteLine("Первый треугольник больше");
            }
            else if (secondTriangle > firstTriangle)
            {
                Console.WriteLine("Второй треугольник больше");
            }
            else
            {
                Console.WriteLine("Треугольники равны");
            }

            Console.ReadKey();
        }
    }
}