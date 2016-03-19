/*
Paul Adams
2/14/16
P04VendingMachine
File Program.cs
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04VendingMachine
{
    class Program
    {
        public static int winHeight;
        public static int winWidth;
        public static List <VendingItemClass>  items;
        public static bool running;
        public static string input;
        public static double balance;

        static void Main(string[] args)
        {

            init();
            do
            {
                displayMachine();
                Console.Write("\t\tInsert a Bill($1, $2, $5, or 0 to end): ");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        displayMachine();                        
                        balance = 1;
                        buyItem();
                        break;
                    case "2":
                        displayMachine();
                        balance = 2;
                        buyItem();
                        break;
                    case "5":
                        displayMachine();
                        balance = 5;
                        buyItem();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        break;
                }

            } while (running);
           
        }
        public static void init()
        {
            fillMachine();
            winWidth = 120;
            winHeight = 30;
            Console.SetWindowSize(winWidth, winHeight);
            running = true;
            balance = 0;
        }

        public static void fillMachine()
        {
            items = new List<VendingItemClass>();
            items.Add(new VendingItemClass("Pepsi 20oz", 2.25, "A1", 6));
            items.Add(new VendingItemClass("Sierra Mist 20oz", 2.25, "A2", 5));
            items.Add(new VendingItemClass("Diet Pepsi 20oz", 2.25, "A3", 5));
            items.Add(new VendingItemClass("Snapple Lemon tea 16oz", 1.55, "B1", 7));
            items.Add(new VendingItemClass("Snapple Diet Lemon tea 16oz", 1.55, "B2", 6));
            items.Add(new VendingItemClass("Snapple Raspberry tea 16oz", 1.55, "B3", 3));
            items.Add(new VendingItemClass("Lays Potato Chips", 1.15, "C1", 6));
            items.Add(new VendingItemClass("Cheetos", 1.05, "C2", 5));
            items.Add(new VendingItemClass("Doritos Cool Ranch", 1.25, "C3", 8));
            items.Add(new VendingItemClass("Twix Bar", 0.95, "D1", 6));
            items.Add(new VendingItemClass("Kit-Kat", 0.95, "D2", 5));
            items.Add(new VendingItemClass("Twizzlers", 0.85, "D3", 2));
            items.Add(new VendingItemClass("Juicy Fruit Gum", 0.55, "E1", 9));
            items.Add(new VendingItemClass("Tic-Tacs", 0.90, "E2", 8));
            items.Add(new VendingItemClass("Doublemint Gum", 0.65, "E3", 4));
        }

        public static void displayMachine()
        {
            Console.Clear();
            Console.WriteLine("Vending Machine");
            for (int i = 0; i < 109; i++)
                Console.Write("~");
            Console.Write("\n");
            for(int i = 0; i < 15; i += 3)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("~ {0,0}: {1,-30}{2,0}: {3,-30}{4,0}: {5,-34}~",items.ElementAt(i).Location, items.ElementAt(i).Item, 
                                items.ElementAt(i + 1).Location, items.ElementAt(i + 1).Item, items.ElementAt(i + 2).Location, items.ElementAt(i + 2).Item);
                            break;
                        case 1:
                            Console.WriteLine("~ Price: {0,-27:C}Price: {1,-27:C}Price{2,-33:C}~",
                                items.ElementAt(i).Price, items.ElementAt(i + 1).Price, items.ElementAt(i + 2).Price);
                            break;
                        case 2:
                            Console.WriteLine("~ Quantity Left: {0,-19}Quantity Left: {1,-19}Quantity Left: {2,-23}~",
                                items.ElementAt(i).Quantity, items.ElementAt(i + 1).Quantity, items.ElementAt(i + 2).Quantity);
                            Console.WriteLine("~{0,108}", "~");
                            break;
                        default:
                            Console.Write("I goofed up something");
                            break;
                    }
                }    
            }
            for (int i = 0; i < 109; i++)
                Console.Write("~");
            Console.Write("\n");
        }
        public static string makeChange(VendingItemClass item)
        {
            balance -= item.Price;
            double dollar = 0, quarter = 0, dime = 0, nickel = 0;
            while(balance >= 1)
            {
                balance -= 1;
                dollar++;
            }
            while(balance >= 0.25)
            {
                balance -= 0.25;
                quarter++;
            }
            while(balance >= 0.10)
            {
                balance -= 0.10;
                dime++;
            }
            while(balance > 0.04)
            {
                balance -= 0.05;
                nickel++;
            }
            string change = "\t\tYour change is " + dollar + " Dollars, " + quarter + " Quarters, " + dime + " Dimes, " + nickel + " Nickels.";
            balance = 0;
            return change;
        }
        public static void buyItem()
        {
            bool run = true;
            do
            {
                
                displayMachine();
                Console.Write("\t\tYour balance is {0:C}. Please make your selection: ", balance);
                string selection = Console.ReadLine();
                foreach(VendingItemClass i in items)
                {
                    if(i.Location.ToUpper() == selection.ToUpper())
                    {
                        if(i.Price > balance)
                        {
                            Console.WriteLine("\t\tYour selected item {0} costs more than your balance", i.Item);
                            Console.WriteLine("\t\tYour money is returned.\t\t\tPress any key to continue");
                            Console.ReadKey();
                            balance = 0;
                            run = false;
                        }
                        else
                        {
                            displayMachine();
                            if(i.Quantity > 0)
                            {
                                
                                Console.WriteLine("\t\tDispensing {0}. ", i.Item);
                                Console.WriteLine(makeChange(i));
                                Console.WriteLine("\t\tPress any key to continue.");
                                Console.ReadKey();
                                i.reduceInventory();
                                run = false;
                            }
                            else
                            {
                                Console.WriteLine("\t\tSorry that item is sold out: Press any key to try again:");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                
            } while(run);

        }
    }
    
}
