using System;

namespace _007
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Solver(n,"A","B","C");
        }

        static void Solver(int n, string from, string to, string work)
        {
            if(n > 1){
                Solver(n-1, from, work, to);
                count++;
                Console.WriteLine("{0}: {1} to {2}",count,from,to);
                Solver(n-1, work, to, from);
            }else{
                count++;
                Console.WriteLine("{0}: {1} to {2}",count,from,to);
            }
        }
    }
}
