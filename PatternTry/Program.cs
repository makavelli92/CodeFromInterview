using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTry
{
    class Program
    {
        static bool TryParse(string value, out int item)
        {
            try
            {
                item = Int32.Parse(value);
                return true;
            }
            catch (ArgumentNullException)
            {
                item = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            //Int32.Parse(null);
            string a;
            int b;
            TryParse(null, out b);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
