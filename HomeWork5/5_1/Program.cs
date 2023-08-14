
namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C#", "Visual Studio"));
            developers.Add(new Programmer("Java", "Intellij"));
            developers.Add(new Programmer("Python", "PyCharm"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Drill"));
            developers.Add(new Builder("Screwdriver"));

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");

            developers.Sort();
            Console.WriteLine("Sorted Developers:");
            foreach (var developer in developers)
            {
                Console.WriteLine($"Tool: {developer.Tool}");
            }

        }
    }
}
