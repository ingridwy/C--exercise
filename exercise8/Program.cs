using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i =1;
            while (i<=5){
                Console.WriteLine(i);
                i++;
            }*/
            int[] luckyNumbers = {2,3,6,4,8,9};
            for(int i = 0; i <luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
