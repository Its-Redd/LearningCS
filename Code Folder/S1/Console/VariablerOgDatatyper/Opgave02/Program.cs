using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave02
{
    class Program
    {
        static void Main(string[] args)
        {


            // Variables
            byte Byte = 255;

            sbyte Sbyte = -128;

            short Short = 32767;

            ushort Ushort = 65535;

            int Int = 2147483647;

            uint Uint = 4294967295;

            long Long = -9223372036854775808;

            ulong Ulong = 18446744073709551615;

            float Float = 6942069420;

            double Double = 69.69420360;

            decimal Decimal = 345435436534245324;


            // Printing
            Console.WriteLine(Byte);
            Console.WriteLine(Sbyte);
            Console.WriteLine(Short);
            Console.WriteLine(Ushort);
            Console.WriteLine(Int);
            Console.WriteLine(Uint);
            Console.WriteLine(Long);
            Console.WriteLine(Ulong);
            Console.WriteLine(Float);
            Console.WriteLine(Double);
            Console.WriteLine(Decimal);






            // Spacing
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
               







            // Min Value & Max Value
            Console.WriteLine($"Byte min:{byte.MinValue}, max:{byte.MaxValue}");
            Console.WriteLine($"Sbyte min:{sbyte.MinValue}, max:{sbyte.MaxValue}");
            Console.WriteLine($"Short min:{short.MinValue}, max:{short.MaxValue}");
            Console.WriteLine($"Ushort min:{ushort.MinValue}, max:{ushort.MaxValue}");
            Console.WriteLine($"Int min:{int.MinValue}, max:{int.MaxValue}");
            Console.WriteLine($"Uint min:{uint.MinValue}, max:{uint.MaxValue}");
            Console.WriteLine($"Long min: {long.MinValue}, max:{long.MaxValue}");
            Console.WriteLine($"Ulong min: {ulong.MinValue}, max:{ulong.MaxValue}");
            Console.WriteLine($"Float min: {float.MinValue}, max:{float.MaxValue}");
            Console.WriteLine($"Double min: {double.MinValue}, max:{double.MaxValue}");
            Console.WriteLine($"Decimal min:{decimal.MinValue}, max:{decimal.MaxValue}");



            // Spacing
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();









            //Math.PI

            float floatPI = 69;
            double doublePI = 420.32;
            decimal decimalPI = 420;

            floatPI = (float)Math.PI;
            doublePI = (double)Math.PI;
            decimalPI = (decimal)Math.PI;

            Console.WriteLine(floatPI);
            Console.WriteLine(doublePI);
            Console.WriteLine(decimalPI);




            // Readline for at den ikke lukker med det samme
            Console.ReadLine();
        }
    }
}
