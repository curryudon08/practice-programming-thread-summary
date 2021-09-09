using System;
using System.Collections.Generic;
using System.Linq;

namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(fib1(n));
            //Console.WriteLine(string.Join(" ",fib2(n).Select(x => x.ToString())));
            Console.WriteLine(fib2(n).Last());
        }

        static int fib1(int a)
        {
            if(a == 1){
                return 1;
            }else if(a == 2){
                return 1;
            }
            return fib1(a -1) + fib1(a -2);
        }

        static int[] fib2(int n)
        {
            var arr = new int[n];
            arr[0] = 1;
            var a = arr[0];
            for (int i = 1; i < n; i++)
            {
                arr[i] = a;
                a += arr[i-1];
            }
            return arr;
        }

    }
}
