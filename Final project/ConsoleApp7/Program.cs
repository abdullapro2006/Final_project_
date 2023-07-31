// See https://aka.ms/new-console-template for more information

﻿using System;
using finalProject.Helpers;

namespace finalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int option;


            do
            {

                Console.WriteLine("1. Operation on Products");
                Console.WriteLine("2. Operation on Sales");
                Console.WriteLine("0. Exit");


                Console.WriteLine("-------------------------");
                Console.WriteLine("Enter an option please:");
                Console.WriteLine("-------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Invalid option!");
                    Console.WriteLine("Enter an option please:");
                    Console.WriteLine("-------------------------");
                }


                switch (option)
                {
                    case 1:
                        SubMenu.ProductsSubMenu();
                       
                        break;
                    case 2:
                        SubMenu.SalesSubMenu();
                        break;
                       
                    case 0:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }

            } while (option != 0);
        }
    }
}
