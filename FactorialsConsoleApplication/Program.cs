/*
 * using system.numerics by adding on references allows bigger integers to be used as int num itself has a softer cap
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialsConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = Fact(10000);
            Console.WriteLine(result);
        }
        static BigInteger Fact(BigInteger n)
        {
            //5! = 5*4*3*2*1
            BigInteger result = n;
            for (BigInteger i = 1; i < n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
