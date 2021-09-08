using System;
using System.Linq;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pin = Console.ReadLine().Trim().Split()
                .Select(x => int.Parse(x))
                .ToArray();

            var frame = 1;
            var score = 0;
            var eachFrameScore = new int[10];
            var i = 0;
            while(i < n){
                if(frame < 10){
                    var addScore = pin[i];
                    if(addScore == 10){
                        score += (addScore + pin[i+1] + pin[i+2]);
                    }else{
                        i++;
                        addScore += pin[i];
                        score += (addScore == 10 ? addScore + pin[i+1] : addScore);
                    }
                    eachFrameScore[frame-1] = score;
                    frame++;
                }else{
                    score += pin[i];
                    eachFrameScore[frame-1] = score;
                }
                i++;
            }

            var o = string.Join(" ", eachFrameScore.Select(x => x.ToString()));
            Console.WriteLine(o);
        }
    }
}
