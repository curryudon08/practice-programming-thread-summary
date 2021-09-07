using System;
using System.Linq;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3,3];

            for(var i = 0 ; i < 3; i++){
                var s = Console.ReadLine().Trim().Split()
                    .Select(v => int.Parse(v))
                    .ToArray();
                for(var j = 0; j < 3; j++){
                    arr[i,j] = s[j];
                }
            }

            for(var i = 0; i < 3; i++){
                var o = string.Format("{0} {1} {2}", arr[0,i], arr[1,i], arr[2,i]);
                Console.WriteLine(o);
            }
        }
    }
}
