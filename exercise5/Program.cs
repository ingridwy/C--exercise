using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
            
            Console.Write("Enter a number:");
            double num1= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator:");
            string op = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2= Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1+num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1-num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1/num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1*num2);
            }
            else
            {
                Console.WriteLine("Invalid Oerator");
            }

        }
        static string GetDay(int dayNum){
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid entry";
                    break;
            }
            return dayName;
        }
    }
}
