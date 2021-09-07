using System;

namespace _023
{
    class Program
    {
        static string[] SeizaName = new string[]{
            "山羊座", 
            "水瓶座", 
            "魚座", 
            "牡羊座", 
            "牡牛座", 
            "双子座", 
            "蟹座", 
            "獅子座", 
            "乙女座", 
            "天秤座", 
            "蠍座", 
            "射手座", 
            "山羊座"
        };

        static DateTime[] SeizaDate = new DateTime[]{
            new DateTime(2020,1,19),    //山羊座
            new DateTime(2020,2,18),    //水瓶座
            new DateTime(2020,3,20),    //魚座
            new DateTime(2020,4,19),    //牡羊座
            new DateTime(2020,5,20),    //牡牛座
            new DateTime(2020,6,21),    //双子座
            new DateTime(2020,7,22),    //蟹座
            new DateTime(2020,8,22),    //獅子座
            new DateTime(2020,9,22),    //乙女座
            new DateTime(2020,10,23),   //天秤座
            new DateTime(2020,11,22),   //蠍座
            new DateTime(2020,12,21),   //射手座
            new DateTime(2021,1,19),    //山羊座
        };

        static void Main(string[] args)
        {
            Console.Write("月\t:");
            var m = int.Parse(Console.ReadLine());

            Console.Write("日\t:");
            var d = int.Parse(Console.ReadLine());
            var dt = new DateTime(2020,m,d);

            for(var i = 0; i < SeizaDate.Length; i++){
                if(SeizaDate[i] >= dt){
                    Console.WriteLine("{0}月{1}日:{2}",m,d,SeizaName[i]);
                    break;
                }
            }
        }
    }
}
