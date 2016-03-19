/*
Paul Adams
Assignment 4 Grade Graph
3/1/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static int a, b, c, d, f;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter twenty letter grades(one for each of twenty students)");
            Console.WriteLine("and then the application will dispay a graph.");
            Console.WriteLine("\tPress any key to begin....");
            Console.ReadKey();
            for(int i = 0; i <20; i++)
            {
                bool valid = false;
                string grade;
                do
                {

                    Console.Clear();
                    Console.WriteLine("Enter a grade for student {0} [A, B, C, D, F]:", i + 1);
                    grade = Console.ReadLine().ToUpper();


                    switch (grade)
                    {
                        case "A":
                            valid = true;
                            a++;
                            break;
                        case "B":
                            valid = true;
                            b++;
                            break;
                        case "C":
                            c++;
                            valid = true;
                            break;
                        case "D":
                            d++;
                            valid = true;
                            break;
                        case "F":
                            f++;
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("That input was not a valid grade. Please try again.");
                            Console.WriteLine("\tPress any key to begin....");
                            Console.ReadKey();
                            valid = false;
                            break;
                    }
                } while (!valid);

                Console.WriteLine("Grade {0} added for student {1}", grade, i + 1);
                Console.WriteLine("\tPress any key to begin....");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\tGrade Graph");
            for (int i = 20; i > 0; i--)
            {
                Console.Write("{0,2}| ", i);
                if( i <= a)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
                if (i <= b)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
                if (i <= c)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
                if (i <= d)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
                if (i <= f)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }

                Console.Write("\n");
            }
            Console.WriteLine(" 0|_______________" );
            Console.WriteLine("    A B C D F");
            Console.WriteLine("\tPress any key to end....");
            Console.ReadKey();
        }
        
    }
}
