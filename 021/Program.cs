using System;

namespace _021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax + by = A1:");
            Console.Write("a:");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            var b = double.Parse(Console.ReadLine());
            Console.Write("A1:");
            var A1 = double.Parse(Console.ReadLine());

            Console.WriteLine("cx + dy = A2:");
            Console.Write("c:");
            var c = double.Parse(Console.ReadLine());
            Console.Write("d:");
            var d = double.Parse(Console.ReadLine());
            Console.Write("A2:");
            var A2 = double.Parse(Console.ReadLine());

            var D = (a * d) - (b * c);
            if(D != 0){
                var x = (A1 / b - A2 / d) / (a / b - c / d);
                var y = (A1 / a - A2 / c) / (b / a - d / c);
                Console.Write("x={0},y={1}",x,y);
            }else{
                Console.WriteLine("error");
            }
        }
    }
}
