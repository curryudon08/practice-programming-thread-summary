using System;

namespace _022
{
    class Program
    {
        static void Main(string[] args)
        {
            var eto = new string[]{"亥","子","丑","寅","卯","辰","巳","午","未","申","酉","戌"};

            var n = int.Parse(Console.ReadLine());
            var j = (n + 9) % 12;
            Console.WriteLine(eto[j]);
        }
    }
}
