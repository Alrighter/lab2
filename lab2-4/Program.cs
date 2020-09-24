using System;

namespace lab2_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "point1");
            Point B = new Point(0, 2, "point2");
            Point C = new Point(2, 2, "point3");
            Point D = new Point(0, 2, "point4");
            
            Figure figure = new Figure(A, B, C, D);

            Console.WriteLine($"Фiгура: {figure.Fname}");
            figure.PerimeterCalculator();

        }
    }
}
