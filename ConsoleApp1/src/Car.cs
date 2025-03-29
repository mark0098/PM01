using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src
{
    public class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int EnginePower { get; set; }

        public Car(string model, decimal price, int enginePower)
        {
            Model = model;
            Price = price;
            EnginePower = enginePower;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Price: {Price}, Engine Power: {EnginePower}";
        }
    }
}
