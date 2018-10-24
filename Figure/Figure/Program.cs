using System;
using Shape.Logic;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(4.5, 5.8);
            Console.WriteLine("Rectangle");
            Console.Write("Perimeter of rectangle with the width {0} and heigth {1}: ", 4.5, 5.8);
            Console.WriteLine(rectangle.Perimenter());
            Console.Write("Square of rectangle with the width {0} and heigth {1}: ", 4.5, 5.8);
            Console.WriteLine(rectangle.Square());
            Console.WriteLine( );

            Area area = new Area(4.5);
            Console.WriteLine("Square");
            Console.Write("Perimeter of square with the one side {0} : ", 4.5);
            Console.WriteLine(area.Perimenter());
            Console.Write("Square of square with the one side {0} : ", 4.5);
            Console.WriteLine(area.Square());
            Console.WriteLine();

            Circle circle = new Circle(4.5);
            Console.WriteLine("Circle");
            Console.Write("Perimeter of circle with this radius {0} : ", 4.5);
            Console.WriteLine(circle.Perimenter());
            Console.Write("Square of circle with this radius {0} : ", 4.5);
            Console.WriteLine(circle.Square());
            Console.WriteLine();

            Elipse elipse = new Elipse(4.5,5.8);
            Console.WriteLine("Elipse");
            Console.Write("Perimeter of rectangle with the small radius {0} and big radius {1}: ", 4.5, 5.8);
            Console.WriteLine(elipse.Perimenter());
            Console.Write("Square of rectangle with the small radius {0} and big radius {1}: ", 4.5, 5.8);
            Console.WriteLine(elipse.Square());
            Console.WriteLine();


            Triangle triangle = new Triangle(4.5, 5.8);
            Console.WriteLine("Triangle");
            Console.Write("Perimeter of rectangular triangle with the one side {0} and the second radius {1}: ", 4.5, 5.8);
            Console.WriteLine(triangle.Perimenter());
            Console.Write("Square of rectangular triangle with small with the one side {0} and the second radius {1}: ", 4.5, 5.8);
            Console.WriteLine(triangle.Square());
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
