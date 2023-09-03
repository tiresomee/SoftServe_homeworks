using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
     public class Triangle
    {
        Point vertex1;
        Point vertex2;
        Point vertex3;

        public Point Vertex1
        {
            get { return vertex1; } 
        }
        public Point Vertex2
        {
            get { return vertex2; }
        }
        public Point Vertex3
        {
            get { return vertex3; }
        }
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;

        }

        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2)));
        }

        public void SideLengths(out double sideOfTriangle1, out double sideOfTriangle2, out double sideOfTriangle3)
        {

            sideOfTriangle1 = Distance(vertex1, vertex2);
            sideOfTriangle2 = Distance(vertex2, vertex3);
            sideOfTriangle3 = Distance(vertex3, vertex1);
     
        }

        public double Perimeter()
        {
            SideLengths(out double sideOfTriangle1, out double sideOfTriangle2, out double sideOfTriangle3);
            return sideOfTriangle1 + sideOfTriangle2 + sideOfTriangle3;
        }

        public double Square()
        {
            SideLengths(out double sideOfTriangle1, out double sideOfTriangle2, out double sideOfTriangle3);
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - sideOfTriangle1) * (p - sideOfTriangle2) * (p - sideOfTriangle3));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertices: \n A: {vertex1} \n B: {vertex2} " +
                $"\n C: {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter() :F2}");
            Console.WriteLine($"Square: {Square() :F2}");
            double side1, side2, side3;
            SideLengths(out side1, out side2, out side3);
            Console.WriteLine($"Side lengths: side1 = {side1}, side2 = {side2}, side3 = {side3}");
        }
    }
}
