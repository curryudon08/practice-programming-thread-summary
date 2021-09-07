using System;
using System.Linq;

namespace _024
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{12, 6, 8, 3, 10, 1, 0, 9};
            var s =  arr
                .Select((v,i) => new {value = v, index = i})
                .OrderByDescending(x => x.value)
                .Take(3);

            foreach(var x in s){
                Console.WriteLine("{0} => {1}", x.index, x.value);
            }
        }
    }
}
