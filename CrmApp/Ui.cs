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
            Console.Title = "CodeHub Learning";
            Console.ForegroundColor = ConsoleColor.Blue;

            List<string> outerCompartment = new List<string>();
            List<string> mainCompartment = new List<string>();

            bool allDone = false;

            while (!allDone)
            {
                Console.WriteLine("\nPlease choose!");
                Console.WriteLine("[1] Run Customers DB");
                Console.WriteLine("[2] Run Products DB");
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
                        RunCustomers.RunDBCustomers();
                        break;
                    case 2:
                        RunProducts.RunDBProducts();
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

        //public int Menu()
        //{
        //    Console.WriteLine("1. Run CustomerDB   2. Run ProductDB");
        //    Console.WriteLine("Give your choice");
        //    int choice = 0;
        //    try
        //    {
        //        choice = Int32.Parse(Console.ReadLine());
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return choice;
        //}



        //public void CreateMenu()
        //{
        //    do
        //    {
        //        int choice = Menu();

        //        switch (choice)
        //        {
        //            case 1:
        //                RunCustomers runCustomers = RunDBCustomers();
        //                break;
        //            case 2:
        //                RunProducts runProducts = RunDBProducts();
        //                break;
        //            case 0:
        //                Console.WriteLine("You selected to exit");
        //                break;

        //        }
        //    }
        //    while (choice != 0);
        //    return Menu;
        //}

    }

    }



