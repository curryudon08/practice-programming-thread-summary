using System;

namespace _018
{
    class Program
    {
        static void Main(string[] args)
        {
            calc(6.2, 12.0, 3.4);
            calc(4.0, 4.0, 1.0);
            calc(0.0000000045, 10.0, 1.0);
        }

        static void calc(double a, double b, double c)
        {
            var d = (b * b) - (4 * a * c);
            if(d > 0){
              var x1 = (-b + Math.Sqrt(d)) / (2 * a);
                var x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("異なる解:{0},{1}",x1,x2);
            }else if(d == 0){
                var x = -b / (2 * a);
                Console.WriteLine("重解:{0}",x);  
            }else{
                //虚数解は考えない
            }
        }
    }
}
