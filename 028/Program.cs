using System;

namespace _028
{
    class Program
    {
        static string Hiragna = 
            "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん";

        static void Main(string[] args)
        {
            var r = new Random();
            var a = Hiragna[r.Next(Hiragna.Length)];
            var b = Hiragna[r.Next(Hiragna.Length)];
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
