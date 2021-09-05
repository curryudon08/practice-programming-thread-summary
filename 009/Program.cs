using System;
using System.Linq;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new float[100];
            var x = 12345;
            for(var i = 0; i < 100; i++){
                x = (997 * x + 1) % 65536;
                arr[i] = (float)x / 65536;
            }

            Console.WriteLine(string.Join(" ",arr.Select(n => n.ToString())));
            Console.WriteLine("平均:{0}",arr.Sum() / 100);
        }
    }
}
