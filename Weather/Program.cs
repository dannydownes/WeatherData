using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Weather
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Weather Data";
            bool loop = true;
            string InputString = "";
            float InputFloat;

            Console.ForegroundColor = ConsoleColor.White;

            while (loop)
            {
                // Welcome message and options
                Console.WriteLine("Welcome to Weather Station Report.\nPlease select an option.\n\n1.\tView data for year.\n2.\tView data for month. \n3.\tView minimum, maximum, mean and median of all data.\n4.\tView all data.\n5.\tExit\n");
                string caseSwitch = (Console.ReadLine());

                //Causes program to loop if input is invalid
                loop = false;

                switch (caseSwitch)
                {
                    // Year data 
                    case "1":
                        // Displays all of the data for a user inputted year
                        Console.WriteLine("\nPlease enter the year you wish to search for:\n");
                        InputFloat = Convert.ToSingle(Console.ReadLine());
                        if (InputFloat <= 2016 && InputFloat >= 1930)
                        {
                            JaggedArray.BuildJA();
                            Console.WriteLine("\nMonth       |Year      |WS1 Air Frost |WS1 Avg Rain  |WS1 Avg Sun   |WS1 Temp Max  |WS1 Temp Min  |WS2 Air Frost |WS2 Avg Rain  |WS2 Avg Sun   |WS2 Temp Max  |WS2 Temp Min  ");
                            Console.WriteLine("____________|__________|______________|______________|______________|______________|______________|______________|______________|______________|______________|______________");
                            Searches.LinearSearch(InputFloat, JaggedArray.AllData, 1);

                            //returns the user to the main menu
                            Console.WriteLine("\nPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                            loop = true;
                            break;
                        }
                        else
                        {
                            // thrown if an invalid input is used
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou used an invalid input.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                            loop = true;
                            break;
                        }

                    // Month data
                    case "2":
                        // Displays all the data for a user inputted months
                        Console.WriteLine("\nPlease enter the month you wish to search for:\n");
                        InputString = Console.ReadLine();
                        if (InputString == "January" || InputString == "january" || InputString == "February" || InputString == "february" || InputString == "March" || InputString == "march" || InputString == "April" || InputString == "april" || InputString == "May" || InputString == "may" || InputString == "June" || InputString == "june" || InputString == "July" || InputString == "july" || InputString == "August" || InputString == "august" || InputString == "September" || InputString == "september" || InputString == "October" || InputString == "october" || InputString == "November" || InputString == "november" || InputString == "December" || InputString == "december")
                        {
                            JaggedArray.BuildJA();
                            InputFloat = Convert.ToSingle(DateTime.ParseExact(InputString, "MMMM", CultureInfo.InvariantCulture).Month);
                            Console.WriteLine("\nMonth       |Year      |WS1 Air Frost |WS1 Avg Rain  |WS1 Avg Sun   |WS1 Temp Max  |WS1 Temp Min  |WS2 Air Frost |WS2 Avg Rain  |WS2 Avg Sun   |WS2 Temp Max  |WS2 Temp Min  ");
                            Console.WriteLine("____________|__________|______________|______________|______________|______________|______________|______________|______________|______________|______________|______________");
                            Searches.LinearSearch(InputFloat, JaggedArray.AllData, 12);

                            //returns the user to the main menu
                            Console.WriteLine("\nPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                            loop = true;
                            break;
                        }
                        else
                        {
                            // thrown if an invalid input is used
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou used an invalid input.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                            loop = true;
                            break;
                        }

                    // MinMaxMedian Values
                    case "3":
                        // Air Frost
                        Console.WriteLine("\n=============================================WS1 Air Frost=========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 2);
                        Sorts.PrintData(2);

                        Console.WriteLine("\n=============================================WS2 Air Frost=========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 7);
                        Sorts.PrintData(7);

                        // Avg Rain
                        Console.WriteLine("\n=============================================WS1 Avg Rain==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 3);
                        Sorts.PrintData(3);

                        Console.WriteLine("\n=============================================WS2 Avg Rain==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 8);
                        Sorts.PrintData(8);

                        // Avg Sun
                        Console.WriteLine("\n=============================================WS1 Avg Sun===========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 4);
                        Sorts.PrintData(4);

                        Console.WriteLine("\n=============================================WS2 Avg Sun===========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 9);
                        Sorts.PrintData(9);

                        // Temp Max
                        Console.WriteLine("\n=============================================WS1 Temp Max==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 5);
                        Sorts.PrintData(5);

                        Console.WriteLine("\n=============================================WS2 Temp Max==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 10);
                        Sorts.PrintData(10);

                        // Temp Min
                        Console.WriteLine("\n=============================================WS1 Temp Min==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 6);
                        Sorts.PrintData(6);

                        Console.WriteLine("\n=============================================WS2 Temp Min==========================================");
                        JaggedArray.BuildJA();
                        Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, 11);
                        Sorts.PrintData(11);

                        //returns the user to the main menu
                        Console.WriteLine("\nPress any key to return to the main menu.");
                        Console.ReadKey();
                        Console.Clear();
                        loop = true;
                        break;

                    // View all data
                    case "4":
                        Console.WriteLine("\nWhich data would you like to sort by?\n1.\tMonth\n2.\tYear\n3.\tWS1 Air Frost\n4.\tWS1 Avg Rain\n5.\tWS1 Avg Sun\n6.\tWS1 Temp Max\n7.\tWS1 Temp Min\n8.\tWS2 Air Frost\n9.\tWS2 Avg Rain\n10.\tWS2 Avg Sun\n11.\tWS2 Temp Max\n12.\tWS2 Temp Min\n");
                        
                        try
                        {
                            int index = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (0 <= index && index < 12)
                            {
                                Console.WriteLine("\nView the data in:\n1.\tAscending Order\n2.\tDescending Order\n");
                                InputString = Console.ReadLine();
                                if (InputString == "1")
                                {
                                    // Displays the data in ascending order
                                    Console.WriteLine("\nMonth       |Year      |WS1 Air Frost |WS1 Avg Rain  |WS1 Avg Sun   |WS1 Temp Max  |WS1 Temp Min  |WS2 Air Frost |WS2 Avg Rain  |WS2 Avg Sun   |WS2 Temp Max  |WS2 Temp Min  ");
                                    Console.WriteLine("____________|__________|______________|______________|______________|______________|______________|______________|______________|______________|______________|______________");
                                    JaggedArray.BuildJA();
                                    Sorts.QuickSortAscending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, index);
                                    JaggedArray.PrintJA();
                                    Console.WriteLine("\nPress any key to return to the main menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    loop = true;
                                    break;
                                }

                                if (InputString == "2")
                                {
                                    // Displays the data in descening order
                                    Console.WriteLine("\nMonth       |Year      |WS1 Air Frost |WS1 Avg Rain  |WS1 Avg Sun   |WS1 Temp Max  |WS1 Temp Min  |WS2 Air Frost |WS2 Avg Rain  |WS2 Avg Sun   |WS2 Temp Max  |WS2 Temp Min  ");
                                    Console.WriteLine("____________|__________|______________|______________|______________|______________|______________|______________|______________|______________|______________|______________");
                                    JaggedArray.BuildJA();
                                    Sorts.QuickSortDescending(JaggedArray.AllData, 0, JaggedArray.AFFloat.Length - 1, index);
                                    JaggedArray.PrintJA();
                                    Console.WriteLine("\nPress any key to return to the main menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    loop = true;
                                    break;
                                }

                                else
                                {
                                    // thrown if an invalid input is used
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nYou selected an invalid option");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nPress any key to return to the main menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    loop = true;
                                    break;
                                }
                            }
                        }
                        catch
                        {
                            // thrown if an invalid input is used
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou selected an invalid option");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                            loop = true;                            
                        }
                        break;

                    // Exit console application
                    case "5":
                        Environment.Exit(0);
                        break;

                    // Exception handling - restarts and displays error message
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou selected an invalid option");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPress any key to return to the main menu.");
                        Console.ReadKey();
                        Console.Clear();
                        loop = true;
                        break;
                }
            }
        }
    }
}
