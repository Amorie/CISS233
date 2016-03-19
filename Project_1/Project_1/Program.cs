/*
Paul Adams
01/24/2016
Project 1
*/
using  System;


namespace Project_1
{
    class Calculator
    
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            bool run = true;
            
            do {
                Console.Clear();
                Console.WriteLine("Please enter your first number");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your second number");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adding these two numbers gives you: ");
                Console.WriteLine(firstNumber + secondNumber);
                Console.Write("Subtracting the sencond number from the first number gives you: ");
                Console.WriteLine(firstNumber - secondNumber);
                Console.Write("Multiplying these two numbers gives you a result of: ");
                Console.WriteLine(firstNumber * secondNumber);
                if (secondNumber == 0)
                {
                    Console.WriteLine("You can not divide a number by 0");
                    Console.WriteLine("You can not mod a number by 0");
                }
                else
                {
                    Console.Write("Dividing the first number by the second number the quatient is: ");
                    Console.WriteLine(firstNumber / secondNumber);
                    Console.Write("If you mod the first number by the second number the reamainder is: ");
                    Console.WriteLine(firstNumber % secondNumber);
                }
                Console.WriteLine("Would you like to put in more numbers? (y/n)");
              
                if( Console.ReadKey().Key != ConsoleKey.Y)
                {
                    run = false;
                }
                
            } while (run);      
        }
    }
}
