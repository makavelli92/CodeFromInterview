using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class A
    {
        public  int t = 13;
        public  void Show()
        {
            Console.WriteLine("class A");
        }
    }
    class B : A
    {
        public virtual void Show()
        {
            Console.WriteLine("class B");
        }
    }
    class C : B
    {
        public new  int t = 67;
        public override void Show()
        {
            Console.WriteLine("class C");
        }
    }
    class D : C
    {
        public new void Show()
        {
            Console.WriteLine("class D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new C();
            ob.Show();
            Console.WriteLine(ob.t);


            Console.ReadLine();
        }
    }
}
