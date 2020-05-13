using System.Collections.Generic;
using System;

namespace CarShopClassLibrary
{
    public class Store
    {
        public List<Car> Inventory { get; set; } = new List<Car>();
        public List<Car> ShoppingCart { get; set; } = new List<Car>();

        public void AddInventory()
        {
            Console.Clear();

            if (Inventory.Count > 0)
            {
                ListInventory();
            }

            Car car = new Car
            {
                Make = Helpers.GetStringInput("Enter a make: "),
                Model = Helpers.GetStringInput("Enter a model: "),
                Price = Helpers.GetDecimalInput("Enter a price: ")
            };

            Inventory.Add(car);
            Console.WriteLine("\nCar added to inventory. Press any key to continue...");
            Console.ReadKey();
        }

        private void ListInventory()
        {
                Console.WriteLine("List of current inventory items: \n");

                var carCount = 1;
                foreach (var item in Inventory)
                {
                    Console.WriteLine($"Car #{carCount}: {item}");
                    carCount++;
                }

                Console.WriteLine();
        }
    }
}
