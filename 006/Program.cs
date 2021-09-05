using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",IsLeapYear(year) ? "閏年" : "平年");
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
