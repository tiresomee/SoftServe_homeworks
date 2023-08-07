using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        { get { return name; } }

        public DateTime BirthYear
        { get { return birthYear; } }

        public Person ()
        {
            name = "Natalia";
            birthYear = new DateTime(2003, 5, 1);
        }

       public Person (string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthYear.Year;
            return age;

        }

        public static Person Input(int i)
        {
            Console.Write($"Enter the name of {i + 1} person: ");
            string name = Console.ReadLine();
            Console.Write($"Enter the birthday year of {i + 1} person: ");
            DateTime birthYear = Convert.ToDateTime( Console.ReadLine() );
            Person person = new Person(name, birthYear);  
            return person;
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name of person: {name}, Age: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator != (Person first, Person second)
        {
            return first.name != second.name;
        }


    }
}
