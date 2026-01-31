using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Point
    {
        private double x;
        private double y;

        public Point(){}

        public void X(double x)
        {
            this.x = x;
        }

        public double X()
        {
            return x;
        }

        public void Y(double y)
        {
            this.y = y;
        }

        public double Y()
        {
            return y;
        }
    }
    public class Challenge1015 : BaseChallenge
    {
        
        public override void Execute()
        {
            List<Point> points = new List<Point>();
            string[] valores;
            for(int i = 0; i < 2; i++)
            {
                valores = Console.ReadLine().Split(' ');
                points.Add(new Point());
                points[i].X(double.Parse(valores[0]));
                points[i].Y(double.Parse(valores[1]));
            }

            Console.WriteLine($"{Distancia(points[1], points[0]):F4}");
        }

        public static double Distancia(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X()-p1.X(), 2) + Math.Pow(p2.Y()-p1.Y(), 2));
        }
    }
}