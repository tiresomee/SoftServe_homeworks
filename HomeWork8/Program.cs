using System.Data;
using System;
using System.Drawing;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Shape> shapes = new List <Shape> ();

            Console.WriteLine("Please enter the data of 10 different shapes (circle and square only): ");
            point: 
            try
            {
                for (int i = 0; i < 3; i++)
                { 
            
                    Console.Write("Enter shape type: ");
                    string shapeType = Console.ReadLine();
                    if (shapeType.ToLower() == "circle" || shapeType.ToLower() == "square")
                    {
                        if (shapeType.ToLower() == "circle")
                        {
                            Console.Write($"Enter the name of {shapeType}: ");
                            string shapeName = Console.ReadLine();
                            Console.Write("Enter the radius of circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Circle(shapeName, radius));
                        }
                        else if (shapeType.ToLower() == "square")
                        {
                            Console.Write($"Enter the name of {shapeType}: ");
                            string shapeName = Console.ReadLine();
                            Console.Write($"Enter side length for the square: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Square(shapeName, side));
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Please enter the shape type - circle or square");
                    }
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto point;
            }
            catch (ApplicationException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto point;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Information about shapes: ");
            foreach ( Shape shape in shapes)
            {
                Console.WriteLine($" Name: {shape.Name}, Perimeter: {shape.Perimeter() :F2}, Area: {shape.Area() :F2}");
            }
            Console.WriteLine("----------------------------------------");

            Shape maxPerimeter = shapes[0];

            foreach ( Shape shape in shapes)
            {
                if (shape.Perimeter() > maxPerimeter.Perimeter())
                {
                    maxPerimeter = shape;
                }
            }

            Console.WriteLine($"The the largest perimeter is {maxPerimeter.Perimeter():F2}, name of shape: {maxPerimeter.Name}");

            Console.WriteLine("---------------------");
            shapes.Sort();
            Console.WriteLine("Sorted area: ");

            foreach ( Shape shape in shapes)
            {
                Console.WriteLine($" Name: {shape.Name}, Perimeter: {shape.Perimeter():F2}, Area: {shape.Area():F2}");
            }


        }
    }
}