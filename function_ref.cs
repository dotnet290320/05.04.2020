using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Foo(ref int y)
        {
            y++;
        }
        static void Main(string[] args)
        {
            int x = 1;
            Foo(ref x); // sending real memory
            Console.WriteLine(x); // 2
        }
    }
}
