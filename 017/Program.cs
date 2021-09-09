using System;
using System.Numerics;
using System.Diagnostics;

namespace _017
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Stopwatch();

            w.Start();
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,0,MyPow1(2,0));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,1,MyPow1(2,1));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,10,MyPow1(2,10));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,100,MyPow1(2,100));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,1000,MyPow1(2,1000));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,10000,MyPow1(2,10000));
            Console.WriteLine("課題1:{0}の{1}乗={2}",2,100000,MyPow1(2,100000));
            w.Stop();
            var el1 = w.Elapsed;
            Console.WriteLine("課題1の処理時間:{0}s",el1);
            Console.WriteLine();
            w.Reset();

            w.Start();
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,0,MyPow2(2,0));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,1,MyPow2(2,1));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,10,MyPow2(2,10));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,100,MyPow2(2,100));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,1000,MyPow2(2,1000));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,10000,MyPow2(2,10000));
            Console.WriteLine("課題2:{0}の{1}乗={2}",2,100000,MyPow2(2,100000));
            w.Stop();
            var el2 = w.Elapsed;
            Console.WriteLine("課題2の処理時間:{0}s",el2);
            Console.WriteLine();
            w.Reset();

            Console.WriteLine("課題1-課題2の時間:{0}s",el1-el2);
        }

        static BigInteger MyPow1(long a, long n)
        {
            var p = new BigInteger(1);
            for (int i = 0; i < n; i++)
            {
                p *= a;
            }
            return p;
        }

        static BigInteger MyPow2(long a, long n)
        {
            var tmp = new BigInteger(a);
            var x = new BigInteger(1);
            while(n > 0){
                if((n & 1) == 1){
                    x *= tmp;
                }
                tmp *= tmp;
                n = n >> 1;
            }
            return x;
        }
    }
}
