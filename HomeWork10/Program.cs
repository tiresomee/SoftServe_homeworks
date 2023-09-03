namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point (1,0), new Point (-4,5), new Point (8,-2)));
            triangles.Add(new Triangle(new Point (4,2), new Point (2,-6), new Point (0,4)));
            triangles.Add(new Triangle(new Point (5,3), new Point (1,4), new Point (2,-1)));

            foreach (var triangle in triangles)
            {
                triangle.Print();
                Console.WriteLine();
            }

            Triangle TriangleclosestToOrigin = triangles[0];
            double closestDistance = double.MaxValue;

            foreach (var triangle in triangles)
            {
                double distance1 = triangle.Distance(triangle.Vertex1, new Point(0, 0));
                double distance2 = triangle.Distance(triangle.Vertex2, new Point(0, 0));
                double distance3 = triangle.Distance(triangle.Vertex3, new Point(0, 0));

                double minDistance = Math.Min(distance1, Math.Min(distance2, distance3));

                if (minDistance < closestDistance)
                {
                    closestDistance = minDistance;
                    TriangleclosestToOrigin = triangle;
                }
            }

            Console.WriteLine("Triangle with closest vertex to the origin:");
            TriangleclosestToOrigin.Print();


        }
    }
}
