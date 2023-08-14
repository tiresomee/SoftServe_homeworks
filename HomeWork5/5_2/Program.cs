using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> personDictionary = new Dictionary<int, string>();

        personDictionary.Add(1, "Olga");
        personDictionary.Add(2, "Petro");
        personDictionary.Add(3, "Oleg");
        personDictionary.Add(4, "Anna");
        personDictionary.Add(5, "Anton");
        personDictionary.Add(6, "Orest");
        personDictionary.Add(7, "Victor");

        Console.WriteLine("Enter an ID to find the corresponding Name: ");
        int findId = System.Convert.ToInt32(Console.ReadLine());

        if (personDictionary.TryGetValue(findId, out string name))
        {
            Console.WriteLine($"We found a name - ({name}) based on your id - ({findId})");
        }
        else
        {
            Console.WriteLine($"this id isn't in the list");
        }

        Console.WriteLine("--------------------------");
        // Task5_2
        List<int> myColl = new List<int>();
        Console.WriteLine("Enter 10 integer numbers: ");

        for (int i = 0; i < 10; i++)
        {
            int num = System.Convert.ToInt32(Console.ReadLine());
            myColl.Add(num);
        }

        bool isFound = false;
        for (int i = 0; i < 10; i++)
        {
            if (myColl[i] == -10)
            {
                Console.WriteLine($"{i} - position of element “-10” in this collection");
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("element (-10) does not exist");
        }

        Console.WriteLine();

        myColl.RemoveAll(item => item > 20);
        Console.WriteLine($"Collection after elements which are greater than 20: ");
        foreach (var item in myColl)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        myColl.Insert(2, 1);
        myColl.Insert(8, -3);
        myColl.Insert(5, -4);
        Console.WriteLine("New collection with inserted items: ");
        foreach (var item in myColl)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        myColl.Sort();
        Console.WriteLine("Sorted collection: ");
        foreach (var item in myColl)
        {
            Console.Write(item + " ");
        }


    }
}