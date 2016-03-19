/*
Paul Adams
2/7/16
Project 03: Student and Employee Entry Application
File: Program.cs
*/

using System;
using System.Collections;


namespace P03StudentEmployeeEntry
{
    class Program
    {
        static bool running;
        static string selection;
        static ArrayList studentList;
        static ArrayList employeeList;


        static void Main(string[] args)
        {
            init();
            do
            {
                Console.Clear();
                displayMenu();
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.Clear();
                        addStudent();
                        break;
                    case "2":
                        Console.Clear();
                        addEmployee();
                        break;
                    case "3":
                        Console.Clear();
                        viewStudents();
                        break;
                    case "4":
                        Console.Clear();
                        viewEmployees();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.Clear();
                        displayMenu();
                        break;
                } 
            }while (running);
        }
        
        static void init()
        {
            running = true;
            studentList = new ArrayList();
            employeeList = new ArrayList();

        }
        static void displayMenu ()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Student/Employee Menu");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("1) Add a Student");
            Console.WriteLine("2) Add an Employee");
            Console.WriteLine("3) View all Students");
            Console.WriteLine("4) View all Employees");
            Console.WriteLine("5) Exit");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Make a selection:");
        }
        static void addStudent()
        {
            
            string name, major, gradYear;
            double gpa;
            Console.WriteLine("Add Student");
            Console.Write("Enter student's full name:  ");
            name = Console.ReadLine();
            while(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Your answer cannot be empty. Please try again!");
                Console.Write("Enter student's full name:  ");
                name = Console.ReadLine();
            }
            Console.Write("\nEnter student's major:  ");
            major = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(major))
            {
                Console.WriteLine("Your answer cannot be empty. Please try again!");
                Console.Write("\nEnter student's major:  ");
                major = Console.ReadLine();
            }
            Console.Write("\nEnter students's graduation year:  ");
            gradYear = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(gradYear))
            {
                Console.WriteLine("Your answer cannot be empty. Please try again!");
                Console.Write("\nEnter students's graduation year:  ");
                gradYear = Console.ReadLine();
            }
            Console.Write("\nEnter student's GPA:  ");
            bool result = double.TryParse(Console.ReadLine(), out gpa );
            while(!result)
            {
                Console.WriteLine("Invalid input please try again!");
                Console.Write("\nEnter student's GPA:  ");
                result = double.TryParse(Console.ReadLine(), out gpa);
            }

            StudentClass stud = new StudentClass(name, major, gradYear, gpa);
            studentList.Add(stud);
        }
        static void addEmployee()
        {
            string name, dept;
            double salary;
            Console.WriteLine("Add Employee");
            Console.Write("Enter employee's full name:  ");
            name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Your answer cannot be empty. Please try again!");
                Console.Write("Enter employee's full name:  ");
                name = Console.ReadLine();
            }
            
            Console.Write("\nEnter employee's department:  ");
            dept = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(dept))
            {
                Console.WriteLine("Your answer cannot be empty. Please try again!");
                Console.Write("\nEnter employee's department:  ");
                dept = Console.ReadLine();
            }
            Console.Write("\nEnter employee's salary:  ");
            bool result = double.TryParse(Console.ReadLine(), out salary);
            while(!result)
            {
                Console.WriteLine("Invalid input please try again!");
                Console.Write("\nEnter employee's salary:  ");
                result = double.TryParse(Console.ReadLine(), out salary);
            }
            EmployeeClass emp = new EmployeeClass(name, dept, salary);
            employeeList.Add(emp);
        }
        static void viewStudents()
        {
            Console.WriteLine("View Students");
            Console.WriteLine("*******************************************************************");

            if (studentList.Count == 0)
            {
                Console.WriteLine("You have not added any students yet.");
            }
            else
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-30}{3,-30}","Name", "Major", "Graduation Year", "Grade Point Average");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                foreach (StudentClass i in studentList)
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}{3,-30:F2}", i.Name, i.Major, i.GraduationYear, i.GPA);
                }
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }
        static void viewEmployees()
        {
            Console.WriteLine("View Employees");
            Console.WriteLine("*******************************************************************");

            if (employeeList.Count == 0)
            {
                Console.WriteLine("You have not added any employees yet.");
            }
            else
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-30}", "Name", "Department", "Salary");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                foreach (EmployeeClass i in employeeList)
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30:C}", i.Name, i.Department, i.Salary);
                }
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
