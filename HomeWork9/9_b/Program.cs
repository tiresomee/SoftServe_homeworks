using System.Data;

namespace HomeWork9b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "D://hw9.txt";
                string[] lines = File.ReadAllLines(filePath);
                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                if (lines.Any())
                {

                    Console.WriteLine("the number of symbols in every line: ");

                    var countOfSymbols = lines.Select(line => line.Length);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine($"Line {i + 1} has {countOfSymbols.ElementAt(i)}");
                    }

                    var longestLine = lines.OrderByDescending(line => line.Length).First();
                    Console.WriteLine($"Longest line is: {longestLine}");

                    Console.WriteLine("-----------------------------------------");

                    var shortestLine = lines.OrderBy(line => line.Length).First();
                    Console.WriteLine($"Shortest line is: {shortestLine}");

                    Console.WriteLine("-----------------------------------------");


                    var linesVar = lines.Where(line => line.Contains("var"));
                    Console.WriteLine("Lines containing the word var:");
                    if (linesVar.Any())
                    {
                        foreach (string line in linesVar)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        throw new ApplicationException("cannot find \"var\"");
                    }

                    var varCount = lines.Sum(line => line.Split(' ').Count(word => word == "var"));
                    Console.WriteLine($"Number of words \"var\": {varCount}");
                }
                else
                {
                    throw new ApplicationException("There is no text in the file");
                }
            }
            catch (ApplicationException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

    }
}
    

