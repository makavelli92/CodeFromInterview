using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Type
{

    class Test<T>
    {

    }
    class Test<T, U>
    {

    }
    struct TestStruct
    {
        public int X { get; set; }
        public int[] y;

        public TestStruct(int x)
        {
            X = x;
            y = new int[6];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestStruct t = new TestStruct();
        }
    }
}
