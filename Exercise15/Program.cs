using System;
using System.Text.RegularExpressions;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");

            double number;
            bool isNumber;
            bool isRepeater;
            string repeater;
            
            
                do
                {
                    do
                    {


                        Console.Write("Enter a number: ");
                        isNumber = double.TryParse(Console.ReadLine(), out number);
                    } while (!isNumber);

                    for (double i = 1; i <= number; i++)
                    {
                        // to cube is power of 3 or exponet ^3
                        Console.Write($"{Math.Pow(i, 3)} ");
                    }

                    do
                {

              
                    Console.Write("\nWould you like to continue (y/n)? ");
                    repeater = Console.ReadLine().ToUpper();
                    isRepeater = Regex.IsMatch($"{repeater}", "[YN]");
                   

                }   while (!isRepeater);

                } while (repeater == "Y");





        }
    }
}