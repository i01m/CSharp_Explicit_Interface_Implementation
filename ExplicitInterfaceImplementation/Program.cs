using System;
using static System.Console;

namespace ExplicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Odd Numbers");

            var generator = new OddGenerator();
            foreach (var odd in generator)
            {
                if (odd > 50)
                    break;
                WriteLine(odd);
            }

            Read();
        }
    }
}
