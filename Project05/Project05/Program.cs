/*
Paul Adams
2/21/16
Project 5
program.cs
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateArea.Area;

namespace Project05
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            do
            {
                Console.Clear();
                Console.WriteLine("Shape Area Calculator");
                Console.WriteLine("**********************************************");
                Console.WriteLine("\t1: Circle");
                Console.WriteLine("\t2. Square");
                Console.WriteLine("\t3. Rectangle");
                Console.WriteLine("\t4. Rhombus");
                Console.WriteLine("\t5. Parallelogram");
                Console.WriteLine("\t6. Trapezoid");
                Console.WriteLine("\t7. Exit");
                Console.WriteLine("**********************************************");
                Console.Write("Select a shape type to calculate: ");
                input = Console.ReadLine();
                //I check input as a string. i didn't feel the need to try to convert it to anything like an int. 
                //I figured, why bother since my switch can handle strings.
                switch (input)
                {
                    case "1": //Circle
                        CalculateCircle();
                        break;
                    case "2": //Square
                        CalculateSquare();
                        break;
                    case "3": //Rectangle
                        CalculateRectangle();
                        break;
                    case "4": //Rhombus
                        CalculateRhombus();
                        break;
                    case "5": //Parallelogram
                        CalculateParallelogram();
                        break;
                    case "6": //Trapezoid
                        CalculateTrapezoid();
                        break;
                }
            } while (input != "7"); //Do While input is not 7. Will exit loop on 7 only.
            //My switch only checks for 1-6. So anything other than 1-6 falls out of my switch 
            //and only 7 exits the program. This means that the screen simply seems to refresh for any other
            //or (bad) input. 
            Console.WriteLine("\nHave a nice day. Goodbye. Press any key...");
            Console.ReadKey();
        }
    }
}
