using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            for (long i=2; i<num; i++){
                if (num % i ==0){
                    bool isDivisor = true;
                    for (long p=2 ;p<i; p++){
                        if (i % p == 0) {
                            isDivisor = false;
                            break;
                        }
                    }
                if (isDivisor) {
                    long factor = i;
                    Console.WriteLine(factor);
                    
                }
                
                }
                
            }
            
        }
    }
}
