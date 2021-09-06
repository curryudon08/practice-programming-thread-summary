using System;
using System.Linq;
using System.Diagnostics;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("year?\t:");
            var y = int.Parse(Console.ReadLine());

            Console.Write("month?\t:");
            var m = int.Parse(Console.ReadLine());

            int[] days = new int[]{31,28,31,30,31,30,31,31,30,31,30,31};
            var d = days[m - 1];
            if(m == 2 && IsLeapYear(y)){
                d++;
            }

            if(m == 1 || m == 2){
                y--;
                m += 12;
            }
            var h = (y + (y / 4) - (y / 100) + (y / 400) + ((13 * m + 8) / 5) + 1) % 7;
            //Console.WriteLine(h);
            //Console.WriteLine(d);

            Console.WriteLine("日\t月\t火\t水\t木\t金\t土");
            var c = Enumerable.Repeat(0,h).Concat(Enumerable.Range(1,d)).ToArray();

            for(var i = 0; i < d + h; i++){
                if(c[i] == 0){
                    Console.Write("\t");
                }else{
                    Console.Write("{0,2}\t",c[i]);
                }

                if((i + 1) % 7 == 0){
                    Console.Write("\n");
                }
            }
        }

        static bool IsLeapYear(int year){
            var ret = false;
            if(year % 4 == 0){
                ret = (year % 100 == 0 && year % 400 != 0) ? false : true;
            }else{
                ret = false;
            }
            return ret;
        }
    }
}
