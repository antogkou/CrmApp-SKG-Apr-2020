using LanguageExt;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class Ui
    {
        public static void Menu()
        {
            //beautify console
            Console.Title = "CodeHub Learning";
            Console.ForegroundColor = ConsoleColor.Blue;

            //loop menu with while and accept only 1-4
            bool allDone = false;
            while (!allDone)
            {
                Console.WriteLine("\nPlease choose!");
                Console.WriteLine("[1] Run Customers CRUD");
                Console.WriteLine("[2] Run Products CRUD");
                Console.WriteLine("[3] Clear Console");
                Console.WriteLine("[4] Exit");
                Console.WriteLine("Please enter your choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Enter a number from 1 to 4: ");
                }

                switch (choice)
                {
                    case 1:
                        CustomersCRUD.RunCustomersCRUD();
                        break;
                    case 2:
                        ProductsCRUD.RunProductsCRUD();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("All done. Have a great day!");
                        allDone = true;
                        break;
                }
            }

            Console.WriteLine("\nDone!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
 }



