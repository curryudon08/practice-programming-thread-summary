using System;
using System.Linq;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = CreateAnswer();
            //Console.WriteLine(string.Join("",ans.Select(x => x.ToString())));
            var turnCount = 1;
            
            while(true){
                Console.Write("{0}ターン目 >>",turnCount);
                var player = GetPlayerChoise();

                var hitCount = CountHit(ans,player);
                var blowCount = ans.Intersect(player).Count() - hitCount;
                Console.WriteLine("Hit:{0},Blow{1}",hitCount,blowCount);
                
                if(hitCount == 4){
                    Console.WriteLine("正解");
                    break;
                }
                turnCount++;
            }
        }

        static int CountHit(int[] answer, int[] player)
        {
            var count = 0;
            for(var i = 0; i < answer.Length; i++){
                if(answer[i] == player[i]){
                    count++;
                }
            }
            return count;
        }

        static int[] CreateAnswer()
        {
            var r = new Random();
            var arr = Enumerable.Range(0,10).OrderBy(x => r.Next()).Take(4);
            return arr.ToArray();
        }

        static int[] GetPlayerChoise()
        {
            var arr = Console.ReadLine()
                .Trim()
                .ToCharArray()
                .Select(x => int.Parse(x.ToString()));
            return arr.ToArray();
        }
    }
}
