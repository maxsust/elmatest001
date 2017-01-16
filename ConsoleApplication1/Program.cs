using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            int result = calc.Sum(1, 2);
            Console.WriteLine($"{result}");
            //  Console.WriteLine(string.Format("{0}",result)); для студия 2013
            Console.ReadKey();
        }
    }
}
