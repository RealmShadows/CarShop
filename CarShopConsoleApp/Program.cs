using CarShopClassLibrary;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            int menuAction;
            do
            {
                menuAction = DisplayMenu(new List<string> { "Add Inventory", "Remove Inventory", "Add to Cart", "Remove an From Cart", "Checkout"});

                switch (menuAction)
                {
                    case 1:
                        store.AddInventory();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

            } while (menuAction != 0);
        }

        static int DisplayMenu(List<string> menu)
        {
            Console.Clear();

            var menuCount = 1;
            foreach(var item in menu)
            {
                Console.WriteLine($"{menuCount} - {item}");
                menuCount++;
            }

            Console.WriteLine("\n0 - Quit\n");

            return GetMenuSelection(menu);
        }

        static int GetMenuSelection(List<string> menu)
        {
            bool isInt;
            int choice;

            do
            {
                Console.Write("Please choose an option: ");
                isInt = int.TryParse(Console.ReadLine(), out choice);

                if (!isInt || choice > menu.Count)
                {
                    Console.WriteLine("\nInvalid selection. Please try again.\n");
                }

            } while (isInt != true || choice > menu.Count);

            return choice;
        }
    }
}
