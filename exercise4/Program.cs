using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(6));
            Console.WriteLine(GetMax(2,5));
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
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2) {
                result = num1;
            }
            else {
                result = num2;
            }
            return result;
        }
    }
}
