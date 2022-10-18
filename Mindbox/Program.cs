using System;
using Mindbox.Square;


namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle1 = new TriangleSquare(3, 4, 5);
            var triangle2 = new TriangleSquare(2, 3, 4);

            Console.WriteLine(triangle1.IsRectangular());

            
            var circle = new CircleSquare(10);

            var shapes = new ISquare[] { triangle1, triangle2, circle };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры {shape.GetType()} = " + shape.Calculate());
            }

            Console.ReadLine();
        }
    }
}
