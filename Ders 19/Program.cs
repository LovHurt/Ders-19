using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 300;
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 100-200");
            }
            else if (number > 0 || number < 200)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            Console.ReadLine();
        }
    }
}
    