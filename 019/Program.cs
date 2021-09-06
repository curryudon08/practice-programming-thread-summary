using System;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 200; i++){
                if(IsAho(i)){
                    Console.Write("aho ",i);
                }else{
                    Console.Write("{0} ",i);
                }                
            }
        }

        static bool IsAho(int n)
        {
            var aho = false;
            if(n % 3 == 0){
                aho = true;
            }else{
                while(n > 0){
                    if(n % 10 == 3){
                        aho = true;
                        break;
                    }
                    n /= 10;
                }
            }
            return aho;
        }
    }
}
