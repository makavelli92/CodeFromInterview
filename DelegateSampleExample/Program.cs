using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSampleExample
{
    class Program
    {
        static Action CreateAction()
        {
            int count = 0;
            Action action = () =>
            {
                count++;
                Console.WriteLine(count);
            };
            return action;
        }
        static void Main(string[] args)
        {
            Action action = CreateAction();
            action();
            action();


            Console.ReadLine();
        }
    }
}
