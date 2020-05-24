using System;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "Hippo";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuess = false;

            while (guess !=secret && !outOfGuess)
            {
                if(guessCount < guessLimit){
                    Console.Write("Enter your guess ");
                    guess = Console.ReadLine();
                    guessCount ++;
                }
                else
                {
                    outOfGuess = true;
                }   
            }
            if(outOfGuess)
                {
                    Console.WriteLine("You Lose!");
                }
                else{
                    Console.WriteLine("You win!");
                }
        }
    }
}
