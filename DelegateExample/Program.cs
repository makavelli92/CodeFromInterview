using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            List<MyDelegate> list = new List<MyDelegate>();

            for (int i = 0; i < 10 ; i++)
            {
              //  int temp = i;
              //  list.Add(() => Console.WriteLine(temp));
                list.Add(()=>Console.WriteLine(i));
            }
            foreach(var i in list)
            {
                i();
            }
            Console.ReadKey();
        }
    }
}
