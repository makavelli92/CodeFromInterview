using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumearbleAndIList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Ivanov");
            list.Add("Petrov");
            list.Add("Semenov");
            IEnumerable<string> getList = list;
            




            Console.ReadLine();
        }
    }
}
