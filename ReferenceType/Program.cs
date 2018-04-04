using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    struct Str
    {
        public int A { get; set; }

        public Str(int a)
        {
            A = a;
        }
    }
    class A
    {
        public int x;
    }
    class Program
    {
        static void Modify(ref A link)
        {
            link.x = 8;
            link = new A();
        }
        static void ModifyStruct(ref Str a)
        {
            a.A = 99;
        }
        static void Main(string[] args)
        {
            Str d = new Str(5);
            ModifyStruct(ref d);
            Console.WriteLine(d.A);
            /*
            A ob = new A { x = 12 };
            Console.WriteLine("ob.x = {0}, ob.HashCode = {1}", ob.x, ob.GetHashCode());
            Modify(ref ob);
            Console.WriteLine("ob.x = {0}, ob.HashCode = {1}", ob.x, ob.GetHashCode());
            */
            Console.ReadLine();
        }
    }
}