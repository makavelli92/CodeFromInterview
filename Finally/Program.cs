using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    class Program
    {

        static void GetException()
        {
            throw new Exception();
        }
        static void GetException2()
        {
            try
            {
                GetException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                GetException2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
