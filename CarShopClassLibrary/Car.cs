using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopClassLibrary
{
    public class Car
    {
        public string Make { get; set; } = "Undefined";
        public string Model { get; set; } = "Undefined";
        public decimal Price { get; set; } = 0.00M;

        public Car()
        {

        }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price; 
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Price: {Price:C2}";
        }
    }
}
