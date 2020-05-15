using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(6));
            Console.WriteLine(GetMax(2,5,20));
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
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1>= num2 && num1 >=num3) {
                result = num1;
            }
            else if(num2>=num1 && num2>=num3) {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}
