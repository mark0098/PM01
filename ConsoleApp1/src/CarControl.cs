using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src
{
    public class CarControl
    {
        private List<Car> cars;

        public CarControl()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void SortCars()
        {
            cars = cars.OrderByDescending(c => c.EnginePower)
                      .ThenBy(c => c.Price)
                      .ToList();
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var car in cars)
                    {
                        writer.WriteLine($"{car.Model},{car.Price},{car.EnginePower}");
                    }
                }
                Console.WriteLine($"Data successfully saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public void DisplayCars()
        {
            Console.WriteLine("\nList of Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
