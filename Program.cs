using System;

class CubicPolynomial
{
    double a3, a2, a1, a0;

    // Конструктор
    public CubicPolynomial(double a3, double a2, double a1, double a0)
    {
        this.a3 = a3;
        this.a2 = a2;
        this.a1 = a1;
        this.a0 = a0;
    }

    // Метод для обчислення мінімуму на [a; b]
    public double GetMin(double a, double b, double e)
    {
        double min = a3 * a * a * a + a2 * a * a + a1 * a + a0;

        for (double x = a; x <= b; x += e)
        {
            double value = a3 * x * x * x + a2 * x * x + a1 * x + a0;
            if (value < min)
                min = value;
        }

        return min;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть кількість многочленів: ");
        int count = Convert.ToInt32(Console.ReadLine());

        CubicPolynomial[] polynomials = new CubicPolynomial[count];

        // Створення масиву об’єктів
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Многочлен " + (i + 1));
            Console.Write("a3 = ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a0 = ");
            double a0 = Convert.ToDouble(Console.ReadLine());

            polynomials[i] = new CubicPolynomial(a3, a2, a1, a0);
        }

        Console.Write("Введіть a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть e: ");
        double e = Convert.ToDouble(Console.ReadLine());

        // Пошук мінімального значення
        double min = polynomials[0].GetMin(a, b, e);
        int index = 0;

        for (int i = 1; i < count; i++)
        {
            double currentMin = polynomials[i].GetMin(a, b, e);
            if (currentMin < min)
            {
                min = currentMin;
                index = i;
            }
        }

        Console.WriteLine("Многочлен з мінімальним значенням: " + (index + 1));
        Console.WriteLine("Мінімальне значення = " + min);
    }
}
