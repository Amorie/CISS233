/*
Paul Adams
2/7/2016
Assignment 02: Powerball Number Generator
*/

using System;


namespace A02PBallGenerator
{
    class Program
    {
        public static Random randomNumber = new Random();
        public static bool running = true;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Powerball Numbers");
            Console.WriteLine("***************************************************************");
            int[] wNumbers = {0,0,0,0,0 };
            int rNumber;
            while (running)
            {
                getNumbers(wNumbers, 5);
                Array.Sort(wNumbers);
                rNumber = getRandomIntInclusive(1, 26);
                Console.Write("\nYour Numbers are: ");
                foreach (int i in wNumbers)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("and your Powerball is : " + rNumber);
                Console.WriteLine("Would you like more numbers?(y/n)");
                bool flag = true;

                while (flag)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.N:
                            running = false;
                            flag = false;
                            break;
                        case ConsoleKey.Y:
                            running = true;
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid input please try again.");
                            break;
                    }
                }
                

            }
            
           

            
        }
        static int getRandomIntInclusive(int min, int max)
        {
            return (randomNumber.Next(min, max + 1));
        }
        
        static int[] getNumbers(int[] array, int size)
        {
            int ranNumber;
            //Loop through our array and set numbers
            for(int i = 0; i < size; i++)
            {
                ranNumber = getRandomIntInclusive(1, 69);
                //Loop backwards from where we are in filling the array 
                for(int x = i; x >= 0; x--)
                {
                    //Check for duplicates if duplicate pick a new number.
                    if(ranNumber == array[x])
                    {
                        ranNumber = getRandomIntInclusive(1, 69);
                        x = i; // Reset loop because we found a duplicate.
                    } 
                }
                array[i] = ranNumber;
                
            }
            return array;
        }
    }
}
