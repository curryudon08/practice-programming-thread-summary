using System;
using System.Linq;

namespace _031
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Enumerable.Range(1, 100).Select(x => x * x).ToArray();

            for(var n = 1; n <= 10000; n++){
                var t = n;
                if(p.Contains(t)){
                    Console.WriteLine("√{0} -> {1}",n, Math.Sqrt(t));
                }else{
                    var x = 1;
                    foreach(var v in p){
                        if(t % v == 0){
                            t /= v;
                            x *= (int)Math.Sqrt(v);
                        }
                    }
                    /*
                    if(n > 20){
                        break;
                    }*/
                    if(x > 1){
                        Console.WriteLine("√{0} -> {1}√{2}",n, x, t);
                    }else{
                        Console.WriteLine("√{0} -> √{1}",n, t);
                    }
                }
            }
        }
    }
}
