using System;

class CubicPolynomial
{
    private double a3, a2, a1, a0;

    public CubicPolynomial(double a3, double a2, double a1, double a0)
    {
        this.a3 = a3;
        this.a2 = a2;
        this.a1 = a1;
        this.a0 = a0;
    }

    public double Value(double x)
    {
        return a3 * x * x * x + a2 * x * x + a1 * x + a0;
    }
}

class Program
{
    static void Main()
    {
        CubicPolynomial[] polynomials =
        {
            new CubicPolynomial(1, -2, 3, -1),
            new CubicPolynomial(-1, 0, 2, 4)
        };

        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть ε: ");
        double eps = double.Parse(Console.ReadLine());

        for (int i = 0; i < polynomials.Length; i++)
        {
            double min = polynomials[i].Value(a);

            for (double x = a; x <= b; x += eps)
            {
                double value = polynomials[i].Value(x);
                if (value < min)
                    min = value;
            }

            Console.WriteLine($"Мінімальне значення {i + 1}-го многочлена: {min}");
        }
    }
}
