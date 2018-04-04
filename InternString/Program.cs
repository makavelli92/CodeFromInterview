using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = new String("Hello".ToCharArray());

            Console.WriteLine(s1 == s2);
            Console.WriteLine((object)s1 == (object)s2);
            Console.WriteLine(Object.ReferenceEquals(s1, s2));

            Console.ReadKey();
        }
    }
}
