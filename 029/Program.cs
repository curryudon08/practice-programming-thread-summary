using System;
using System.Linq;

namespace _029
{
    class Program
    {
        static void Main(string[] args)
        {
            var StartYear = 1896;
            var notHold = new int[]{1916,1940,1944};

            for (int i = 0; StartYear + i <= DateTime.Today.Year; i += 4)
            {
                var y = StartYear + i;
                if(!notHold.Contains(y)){
                    Console.WriteLine("第{0,2}回 {1}",i / 4 + 1,y);
                }                
            }
        }
    }
}
