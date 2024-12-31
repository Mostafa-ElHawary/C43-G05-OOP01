using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01_Assignment
{
    internal struct Point
    {
        private double X;
        private double Y;

        
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public static Point GetPointFromInput(string pointName)
        {
            Console.WriteLine($"Enter coordinates for {pointName}:");
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine()); 
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());

            return new Point(x, y);
        }



        //public double GetX() => X;
        //public double GetY() => Y;

    }
}
