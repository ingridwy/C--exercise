﻿using System;

namespace exercise1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int result= 0;
            for(int i=1; i < 1000; i++){
                if ((i%3)==0 || (i%5)==0){
                    result+=i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
