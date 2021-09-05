using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("Hello World! {0}",i + 1));                
            }
        }
    }
}
