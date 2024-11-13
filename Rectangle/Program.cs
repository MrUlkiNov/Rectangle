using System;

namespace GeometryApp
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and Height must be positive numbers.");

            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            if (radius <= 0 || height <= 0)
                throw new ArgumentException("Radius and Height must be positive numbers.");

            Radius = radius;
            Height = height;
        }

        public double CalculateVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Вычислить площадь прямоугольника");
            Console.WriteLine("2. Вычислить объем цилиндра");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CalculateRectangleArea();
                    break;
                case "2":
                    CalculateCylinderVolume();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Программа завершена.");
                    break;
            }
        }

        private static void CalculateRectangleArea()
        {
            Console.WriteLine("Введите ширину прямоугольника:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту прямоугольника:");
            double height = double.Parse(Console.ReadLine());

            try
            {
                var rectangle = new Rectangle(width, height);
                double area = rectangle.CalculateArea();
                Console.WriteLine($"Площадь прямоугольника: {area}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private static void CalculateCylinderVolume()
        {
            Console.WriteLine("Введите радиус цилиндра:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра:");
            double height = double.Parse(Console.ReadLine());

            try
            {
                var cylinder = new Cylinder(radius, height);
                double volume = cylinder.CalculateVolume();
                Console.WriteLine($"Объем цилиндра: {volume}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
