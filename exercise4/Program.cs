using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(6));
        }
        static int cube(int num){
            int result = num*3;
            return result;
        }
    }
}
