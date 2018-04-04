using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class A
    {
        public int x;

        public override bool Equals(object obj)
        {
            return this.x == ((A)obj).x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A { x = 10 };
            A a2 = new A { x = 10 };
            Console.WriteLine((Object)a1 == (Object)a2);
            Console.WriteLine(a1.Equals(a2));

            Console.ReadKey();

        }
    }
}
