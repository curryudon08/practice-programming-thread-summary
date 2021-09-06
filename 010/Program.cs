using System;


namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var x = r.Next(1, 101);

            while(true){
                var n = int.Parse(Console.ReadLine());
                if(n == x){
                    Console.WriteLine("正解");
                    break;
                }else if(n > x){
                    Console.WriteLine("もっと小さい");
                }else{
                    Console.WriteLine("もっと大きい");
                }
            }
        }
    }
}
