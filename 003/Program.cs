using System;
using System.Collections.Generic;

namespace _003
{
    class Program
    {
        //与えられた数までの素数を列挙する
        static void Main(string[] args)
        {
           var n = long.Parse(Console.ReadLine());

            foreach(var i in GetPrimeNumber(n)){
                Console.WriteLine(i);
            }

        }

        static IEnumerable<long> GetPrimeNumber(long n){
            if(n >= 2){
                yield return 2;
            }

            for(var i = 3; i <= n; i += 2){
                var flag = true;
                var sqrtnum = Math.Sqrt(i);
                for(var j = 3; j <= sqrtnum; j += 2){
                    if(i % j == 0){
                        flag = false;
                        break;
                    }
                }
                if(flag){
                    yield return i;
                }
            }
        }
    }
}
