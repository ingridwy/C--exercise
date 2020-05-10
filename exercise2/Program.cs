using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            long fib1=1;
            long fib2=1;
            long newNumber=0;
            long sum=0;
            while (newNumber < 4000000) {
                if (newNumber%2==0) {
                sum+=newNumber;
                }
            newNumber = fib1 +fib2;
            fib2 = fib1;
            fib1 = newNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
