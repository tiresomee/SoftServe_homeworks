using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public abstract class Shape : IComparable
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual string Name { get { return name; } }

        public abstract double Area();
        public abstract double Perimeter();

        public virtual int CompareTo(object obj)
        {
            Shape shape1 = obj as Shape;
            if (shape1 == null)
                throw new ArgumentException("Object is not a Shape");
            else
                return this.Area().CompareTo(shape1.Area());
        }
    }
}
