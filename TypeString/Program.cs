using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeString
{
    class Program
    {
        static string F(string s)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp.Append(s[i]);
            }
            return temp.ToString();
        }

        static void Main(string[] args)
        {

        }
    }
}
