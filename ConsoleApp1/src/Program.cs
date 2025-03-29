using System;
using ConsoleApp1.src;

class Program
{
    static void Main(string[] args)
    {
        CarControl carControl = new CarControl();

        Console.WriteLine("Введите количество машин:");
        int numberOfCars;
        while (!int.TryParse(Console.ReadLine(), out numberOfCars) || numberOfCars <= 0)
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое положительное число:");
        }

        for (int i = 0; i < numberOfCars; i++)
        {
            Console.WriteLine($"\nВведите данные для автомобиля #{i + 1}:");

            Console.Write("Модель: ");
            string model = Console.ReadLine();

            Console.Write("Цена: ");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное число:");
            }

            Console.Write("Мощность двигателя (ЛС): ");
            int enginePower;
            while (!int.TryParse(Console.ReadLine(), out enginePower) || enginePower <= 0)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите целое положительное число:");
            }

            carControl.AddCar(new Car(model, price, enginePower));
        }

        carControl.DisplayCars();
        carControl.SortCars();

        Console.WriteLine("\nПосле сортировки:");
        carControl.DisplayCars();

        Console.WriteLine("\nВведите путь к файлу для сохранения данных (e.g., cars.txt):");
        string filePath = Console.ReadLine();
        carControl.SaveToFile(filePath);
    }
}