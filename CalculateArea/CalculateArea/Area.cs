using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Area
    {
        static public void CalculateCircle()
        {
            //area = pi * radius * radius (or pi times radius squared)
            Console.Clear();
            Console.WriteLine("Circle Area Calculator\n");
            Double radius = GetNumberInput("the circle's radius");
            if (radius != -1)
            {
                Console.Clear();
                Console.WriteLine("Circle Area Calculator\n");
                Console.WriteLine("You've entered {0} for the radius.", radius);
                Console.WriteLine("The area of the circle is: {0}", Math.PI * Math.Pow(radius, 2d));
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
            }
        }

        static public void CalculateSquare()
        {
            //area = side * side (or side squared)
            Console.Clear();
            Console.WriteLine("Square Area Calculator\n");
            Double side = GetNumberInput("the square's side");
            if (side != -1)
            {
                Console.Clear();
                Console.WriteLine("Square Area Calculator\n");
                Console.WriteLine("You've entered {0} for the side.", side);
                Console.WriteLine("The area of the square is: {0}", Math.Pow(side, 2d));
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
            }
        }

        static public void CalculateRectangle()
        {
            //area = Length * Width
            Console.Clear();
            Console.WriteLine("Rectangle Area Calculator\n");
            Double length = GetNumberInput("one side of a rectangle");
            if (length != -1)
            {
                Double width = GetNumberInput("an adjacent side of a rectangle");
                if (width != -1)
                {
                    Console.Clear();
                    Console.WriteLine("Rectangle Area Calculator\n");
                    Console.WriteLine("You've entered {0} for the first side.", length);
                    Console.WriteLine("You've entered {0} for the other side.", width);
                    Console.WriteLine("The area of the rectangle is: {0}", length * width);
                    Console.WriteLine("\nPress any key to continue....");
                    Console.ReadKey();
                }
            }
        }

        static public void CalculateRhombus()
        {
            //area = ½ a * b (a and b being diagonals)
            Console.Clear();
            Console.WriteLine("Rhombus Area Calculator\n");
            Double diagonal1 = GetNumberInput("one diagonal of a rhombus");
            if (diagonal1 != -1)
            {
                Double diagonal2 = GetNumberInput("the other diagonal of a rhombus");
                if (diagonal2 != -1)
                {
                    Console.Clear();
                    Console.WriteLine("Rhombus Area Calculator\n");
                    Console.WriteLine("You've entered {0} for the first diagonal.", diagonal1);
                    Console.WriteLine("You've entered {0} for the other diagonal.", diagonal2);
                    Console.WriteLine("The area of the rhombus is: {0}", (diagonal1 * diagonal2) / 2);
                    Console.WriteLine("\nPress any key to continue....");
                    Console.ReadKey();
                }
            }
        }

        static public void CalculateParallelogram()
        {
            //area = base * height
            Console.Clear();
            Console.WriteLine("Parallelogram Area Calculator\n");
            Double pBase = GetNumberInput("the base of the parallelogram");
            if (pBase != -1)
            {
                Double pHeight = GetNumberInput("the height of the parallelogram");
                if (pHeight != -1)
                {
                    Console.Clear();
                    Console.WriteLine("Parallelogram Area Calculator\n");
                    Console.WriteLine("You've entered {0} for the base.", pBase);
                    Console.WriteLine("You've entered {0} for the height.", pHeight);
                    Console.WriteLine("The area of the parallelogram is: {0}", pBase * pHeight);
                    Console.WriteLine("\nPress any key to continue....");
                    Console.ReadKey();
                }
            }
        }

        static public void CalculateTrapezoid()
        {
            //area = ½ height * (largeBase + smallBase)
            Console.Clear();
            Console.WriteLine("Trapezoid Area Calculator\n");
            Double lBase = GetNumberInput("the large base of the trapezoid");
            if (lBase != -1)
            {
                Double sBase = GetNumberInput("the small base of the trapezoid");
                if (sBase != -1)
                {
                    Double tHeight = GetNumberInput("the height of the trapezoid");
                    if (tHeight != -1)
                    {
                        Console.Clear();
                        Console.WriteLine("Trapezoid Area Calculator\n");
                        Console.WriteLine("You've entered {0} for the large base.", lBase);
                        Console.WriteLine("You've entered {0} for the small base.", sBase);
                        Console.WriteLine("You've entered {0} for the height.", tHeight);
                        Console.WriteLine("The area of the trapezoid is: {0}", (lBase + sBase) * (tHeight / 2));
                        Console.WriteLine("\nPress any key to continue....");
                        Console.ReadKey();
                    }
                }
            }
        }

        //Passes in a prompt (string) for what dimension to ask the user for. Returns a string.
        static String GetStringInput(String prompt)
        {
            //This method only checks for a non-empty string to return.
            String input;
            Boolean isValid = false;
            do
            {
                Console.Write("Enter the length of {0} (-1 to exit back to menu): ", prompt);
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nYour string can't be empty. Please try again.\n");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);
            return input;
        }

        //Passes in a prompt (string) for what dimension to ask the user for. Returns a number.
        static Double GetNumberInput(String prompt)
        {
            //This is a reusable method for getting the number input
            //You didn't need to error check but this method does check for a valid double greater than zero
            //or -1 to end.
            String input;
            Double number = 0;
            input = GetStringInput(prompt);
            if (input != "-1")
            {
                if (!(Double.TryParse(input, out number)))
                {
                    Console.WriteLine("\nThat is not a valid number. Please try again.\n");
                    number = GetNumberInput(prompt); //Recursively calls GetNumberInput if invalid input.
                }
                else if (number < 0)
                {
                    Console.WriteLine("\nYour length must be greater than zero. Please try again.\n");
                    number = GetNumberInput(prompt); //Recursively calls GetNumberInput if number < 0.
                }
            }
            else
                number = -1;
            return number;
        }
    }
}
