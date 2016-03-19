/*
Paul Adams
1/31/2016
Project 02
*/

using System;


namespace Project02AreaCalculator
{
    class Program
    {

        static private bool end = false;
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 15);
            do
            {
                DisplayMainMenu();
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1": CalculateCircle();
                        break;
                    case "2": CalculateSquare();
                        break;
                    case "3": CalculateRectangle();
                        break;
                    case "4": CalculateRhombus();
                        break;
                    case "5": CalculateParallelogram();
                        break;
                    case "6": CalculateTrapezoid();
                        break;
                    case "7": end = true;
                        break;
                    default: DisplayMainMenu();
                        break;
                }
                
                
            } while (end == false);
            EndProgram();
            
        }
        static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Shape Area Calculator\n");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("\t1. Cirlce");
            Console.WriteLine("\t2. Square");
            Console.WriteLine("\t3. Rectangle");
            Console.WriteLine("\t4. Rhombus");
            Console.WriteLine("\t5. Parallelogram");
            Console.WriteLine("\t6. Trapezoid");
            Console.WriteLine("\t7. Exit");
            Console.WriteLine("**********************************************************");
        }
        static private void EndProgram()
        {
            end = true;
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }

        static private void CalculateCircle()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Circle \n (at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Enter the circles radius:");
            double radius;
            bool result = double.TryParse(Console.ReadLine(), out radius);
            if(result)
            {
                if (radius != -1)
                {
                    double area = Math.PI * radius * radius;
                    Console.WriteLine("The circles area is " + area);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                }

            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }

        }

        static private void CalculateSquare()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Square \n(at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Enter the side of the square: ");
            double side;
            bool result = double.TryParse(Console.ReadLine(), out side);
            if (result)
            {
                if (side != -1)
                {
                    double area = side * side;
                    Console.WriteLine("The squares area is " + area);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                }
                
            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }

        }

        static private void CalculateRectangle()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Rectangle \n(at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Enter the length of the rectangle:");
            double length;
            double width;
            bool result = double.TryParse(Console.ReadLine(), out length);
            if(result)
            {
                if (length != -1)
                {
                    Console.WriteLine(" Enter the width of the rectangle:");
                    result = double.TryParse(Console.ReadLine(), out width);
                    if (result)
                    {
                        if (width != -1)
                        {
                            double area = length * width;
                            Console.WriteLine("The area of the rectangle is " + area);
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                        Console.ReadKey();
                    }
                    
                }
            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }

        }

        static private void CalculateRhombus()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Rhombus \n(at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Enter this first diagnal:");
            double diag1;
            double diag2;
            bool result = double.TryParse(Console.ReadLine(), out diag1);
            if(result)
            {
                if(diag1 != - 1)
                {
                    Console.WriteLine("Enter this second diagnal:");
                    result = double.TryParse(Console.ReadLine(), out diag2);
                    if (result)
                    {
                        if (diag2 != -1)
                        {
                            double area = diag1 * diag2 * .5;
                            Console.WriteLine("The area of the rhombus is " + area);
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                        Console.ReadKey();
                    }
                    
                }
            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }

        }

        static private void CalculateParallelogram()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Parallelogram \n(at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            double base1;
            double height;
            Console.WriteLine("Enter the base of the parallelogram:");
            bool result = double.TryParse(Console.ReadLine(), out base1);
            if(result)
            {
                if(base1 != -1)
                {
                    Console.WriteLine("Enter the height of the parallelogram:");
                    result = double.TryParse(Console.ReadLine(), out height);
                    if(result)
                    {
                        if(height != -1)
                        {
                            double area = base1 * height;
                            Console.WriteLine("The area of the parallelogram is " + area);
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                        }
                    } else
                    {
                        Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                        Console.ReadKey();
                    }
                }
            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }
        }

        static private void CalculateTrapezoid()
        {
            Console.Clear();
            Console.WriteLine("Caculate Area of Trapezoid \n(at any time enter -1 to return to the Main Menu).");
            Console.WriteLine("**********************************************************");
            double largeBase;
            double smallBase;
            double height;
            Console.WriteLine("Enter the large base of the trapezoid:");
            bool result = double.TryParse(Console.ReadLine(), out largeBase);
            if(result)
            {
                if(largeBase != -1)
                {
                    Console.WriteLine("Enter the small base of the trapezoid:");
                    result = double.TryParse(Console.ReadLine(), out smallBase);
                    if(result)
                    {
                        if(smallBase != -1)
                        {
                            Console.WriteLine("Enter the height of the trapezoid:");
                            result = double.TryParse(Console.ReadLine(), out height);
                            if(result)
                            {
                                if(height != -1)
                                {
                                    double area = (largeBase + smallBase) * height * .5;
                                    Console.WriteLine("The area of the trapezoid is " + area);
                                    Console.WriteLine("Press any key to return to menu.");
                                    Console.ReadKey();
                                }
                            } else
                            {
                                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                                Console.ReadKey();
                            }
                        }
                    } else
                    {
                        Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                        Console.ReadKey();
                    }
                }
            } else
            {
                Console.WriteLine("Invalid input. \nPress any key to return to Main Menu");
                Console.ReadKey();
            }

        }
    }
}
