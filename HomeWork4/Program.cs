
namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about person with default constructor: ");
            Person person1 = new Person();
            person1.Output();

            Console.WriteLine();

            Console.WriteLine("Information about person using constructor with 2 parameters: ");
            DateTime birthDate = new DateTime(2000, 6, 15);
            Person person2 = new Person("Oleg", birthDate);
            person2.Output();

            Console.WriteLine();

            Console.WriteLine("Enter information about 5 persons: ");
            Person[] persons = new Person[5];
            for ( int i = 0; i< persons.Length; i++ )
            {
                persons[i] = Person.Input(i);
            }

            Console.WriteLine();

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i]} and {persons[j]} have the same name");
                    }

                }

            }

            Console.WriteLine();

            foreach (var person in persons)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }             
            }

            Console.WriteLine("New information about persons: ");
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }

        }
        
          
   



    }
    
}

