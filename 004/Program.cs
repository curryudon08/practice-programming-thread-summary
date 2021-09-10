using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());

            //微分を用いて近似していく
            double b = a;
            for(int i = 0; i < 1000; i++){
                b = (b * b + a) / (2 * b);
            }
            Console.WriteLine(b);
        }
    }
}
