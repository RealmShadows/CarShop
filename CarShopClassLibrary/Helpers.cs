using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopClassLibrary
{
    public class Helpers
    {
        public static string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static decimal GetDecimalInput(string prompt)
        {
            bool isDecimal;
            decimal GetDecimalInput;

            do
            {
                Console.Write(prompt);
                isDecimal = decimal.TryParse(Console.ReadLine(), out GetDecimalInput);

                if (!isDecimal)
                {
                    Console.WriteLine("\nInvalid input. Please try again.\n");
                }

            } while (isDecimal != true);

            return GetDecimalInput;
        }
    }
}
