using System;

namespace Ejemplo002
{
    class Program
    {
        static void Main(string[] args)
        {
            //int - 32-bit signed integer type
            int i = 55;
            //char - 16-bit Unicode character
            char ch = 'A';
            //short - 16-bit signed integer type
            short s = 56;
            //long - 64-bit signed integer type
            long l = 5564;
            //uint - 32-bit unsigned integer type
            uint ui = 100;
            //ushort - 16-bit unsigned integer type
            ushort us = 80;
            //ulong - 64-bit unsigned integer type
            ulong ul = 3625573;
            //double - 64-bit double precision floating point type
            double d = 6.358674532;
            //float - 32-bit single-precision floating point type
            //float needs 'f' or 'F' as suffix
            float f = 2.7330645f;
            //decimal - 128-bit precise decimal values with 28-29 significant digits
            //decimal needs 'm' or 'M' as suffix
            decimal dec = 339.5m;
            Console.WriteLine("Integer: " + i);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Short: " + s);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
            Console.WriteLine("Double: " + d);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Decimal: " + dec);
        }
    }
    
}
