using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Programmer : IDeveloper
    {
        private string language;

        public string Language { get { return language; } }

        public string Tool { get; set; }

        public Programmer(string language, string Tool) 
        {
            this.language = language;
            this.Tool = Tool;
        }

        public void Create()
        {
            Console.WriteLine($"Programmer create smth using {language} and tool - {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer destroy smth using {language} and tool - {Tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
