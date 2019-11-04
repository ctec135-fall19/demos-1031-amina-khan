using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("101 + 99 = {0}", MyMath1.Add(101, 99));
            // this wil result in 
            Console.WriteLine("101 + 201 = {0}", MyMath1.Add(101, 201));
            // byte is 255 bits, insignificant bits will be lost 
        }
    }
}
