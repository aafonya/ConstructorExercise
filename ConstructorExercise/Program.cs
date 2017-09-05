using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            A newA = new B("newB");
            Console.WriteLine("");
            B newB = new B();
            Console.WriteLine("");
            B newB2 = new B("Bee");
            Console.WriteLine("");
            Y newY = new Y();
            Console.WriteLine("");
            Z newZY = new Y();
        }
    }
    class Z
    {
        public Z(string Date)
        {
            Console.WriteLine("Z - with parameter");
        }
    }

    class Y : Z
    {
        public Y() : base("Date")
        {
            Console.WriteLine("Y - with Z");
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A - default"); 
        }
        public A(string name)
        {
            Console.WriteLine("A - with parameter"); 
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B - default"); 
        }

        //public B(string name) 
        //{
        //    Console.WriteLine("B - with parameter");
        //}

        public B(string name) : base(name)
        {
            Console.WriteLine("B - with A's parameter");
        }
    }
}
