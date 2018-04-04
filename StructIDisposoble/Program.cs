using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructIDisposoble
{
    struct MyStruct : IDisposable
    {
        private bool dispose;

        public void Dispose()
        {
            dispose = true;
            Console.WriteLine("Call Dispose");
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
    class Program
    {
        static void ValueTypeDisposoble()
        {
            MyStruct s = new MyStruct();
            try
            {
                Console.WriteLine(s.GetDispose());
            }
            finally
            {
                s.Dispose();
            }
            Console.WriteLine(s.GetDispose());
        }
        static void SynthacsisUsing()
        {
            MyStruct s = new MyStruct();
            try
            {
                Console.WriteLine(s.GetDispose());
            }
            finally
            {
                ((IDisposable)s).Dispose(); // Произошел boxing
            }
            Console.WriteLine(s.GetDispose());
        }
        static void Main(string[] args)
        {
            MyStruct s = new MyStruct();
            using (s)
            {
                Console.WriteLine(s.GetDispose());
            }
            Console.WriteLine(s.GetDispose());

            //  SynthacsisUsing();
            //ValueTypeDisposoble();

            Console.ReadLine();
        }
    }
}
