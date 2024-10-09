using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,
                y = 11;

            Console.WriteLine($"1. íratás = {x}, x++ = {x++}");
            Console.WriteLine($"2. íratás = {x}, x++ = {x++}");
            Console.WriteLine($"1. íratás = {y}, ++y = {++y}");
            Console.WriteLine($"2. íratás = {y}, ++y = {++y}");
            Console.ReadKey();
        }
    }
}
