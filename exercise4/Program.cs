using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(6));
            bool isDog = true;
            if (isDog)
            {
                Console.WriteLine("This is a Dog!");
            }
            else
            {
                Console.WriteLine("This is not a Dog!");
            }
        }
        static int cube(int num){
            int result = num*3;
            return result;
        }
    }
}
