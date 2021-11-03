using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Введите радиус: ");
                double Radius = Convert.ToDouble(Console.ReadLine());
                if (Radius <= 0)
                {
                    Console.Write("Радиус должен быть положительным числом!");
                    Console.ReadKey();
                    return;
                }
                Console.Write("Введите координату х: ");
                double X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату у: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                Circle.Length(Radius);
                Circle.Square(Radius);
                Circle.Position(Radius, X, Y);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат!");
                Console.ReadKey();
                return;
            }
        }
        static class Circle
        {
            public static void Length(double Radius)
            {
                double Length = Math.PI * 2 * Radius;
                Console.WriteLine("Длина окружности: {0:f2}", Length);
            }
            public static void Square(double Radius)
            {
                double Square = Math.PI * Radius* Radius;
                Console.WriteLine("Площадь круга: {0:f2}", Square);
            }
            public static void Position(double Radius, double X, double Y)
            {
                if (X <= Radius && Y <= Radius)
                {
                    Console.WriteLine("Точка ({0},{1}) принадлежит кругу с радиусом {2}", X, Y, Radius);
                }
                else
                {
                    Console.WriteLine("Точка ({0},{1}) не принадлежит кругу с радиусом {2}", X, Y, Radius);
                }
                Console.ReadKey();
            }
        }
    }
}
