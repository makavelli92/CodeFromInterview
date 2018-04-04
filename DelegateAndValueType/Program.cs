using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A";
            Action action = () =>
            {
                Console.WriteLine(s);
                s = "B";
            };
            s = "C";
            action();
            Console.WriteLine(s);
            Action<int> action1 = (int c) =>
            {
                Console.WriteLine(c + 1);
            };


            Console.ReadLine();
        }
    }
}
