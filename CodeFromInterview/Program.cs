using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFromInterview
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("class A");
        }
    }
    class B : A
    {
        public new virtual void Show()
        {
            Console.WriteLine("class B");
        }
    }
    class C : B
    {
        public override void Show()
        {
            Console.WriteLine("class C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new C();
            ob.Show();


            Console.ReadLine();
        }
    }
}
