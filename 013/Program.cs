using System;
using System.Linq;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[]{3, 5, 2, 4, 2};

            for(var i = 0; i < a.Length; i++){
                if(i != 0){
                    a[i] = 0;
                }
            }

            Console.WriteLine(string.Join(" ", a.Select(x => x.ToString())));
        }
    }
}
