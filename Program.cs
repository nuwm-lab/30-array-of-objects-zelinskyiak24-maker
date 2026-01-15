using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть сторону a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Усі сторони мають бути більші за 0!");
            }
            else if (!(a + b > c && a + c > b && b + c > a))
            {
                Console.WriteLine("Трикутник з такими сторонами не існує!");
            }
            else if (!(a == b || a == c || b == c))
            {
                Console.WriteLine("Трикутник не є рівнобедреним!");
            }
            else
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Площа трикутника: {s}");
            }
        }
    }

