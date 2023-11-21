////Напишите метод, который принимает в качестве параметров координаты точки на плоскости (Х и У) и возвращает расстояние между этой точкой и началом координат.

using System;

public class MyClass
{
    // Метод для вычисления расстояния между точкой и началом координат
    public double DistanceToOrigin(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите координату x точки:");
        double px = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координату y точки:");
        double py = double.Parse(Console.ReadLine()!);

        MyClass myClass = new MyClass();

        // Вызываем метод DistanceToOrigin для вычисления расстояния
        double distance = myClass.DistanceToOrigin(px, py);

        Console.WriteLine($"Расстояние от точки до начала координат: {distance}");
    }
}
