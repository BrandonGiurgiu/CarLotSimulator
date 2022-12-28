using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();

            //TODO
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            // 1st method (using Dot Notation)
            var brandonCar = new Car();
            brandonCar.Year = 2020;
            brandonCar.Make = "Ford";
            brandonCar.Model = "Focus";
            brandonCar.EngineNoise = "Vroom";
            brandonCar.HonkNoise = "Beep";
            brandonCar.IsDrivable = true;

            lot.Cars.Add(brandonCar);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            // 2nd method (Object Initializer Syntax)
            var stevesCar = new Car()
            {
                Year = 2013,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "VROOOM",
                HonkNoise = "RAAHHH",
                IsDrivable = true

            };

            lot.Cars.Add(stevesCar);
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            // 3rd Method (Using Constructor to allow parameters placed in properties)
            var dadsCar = new Car(2013, "Toyota", "Tacoma", "Vroom", "Aruga", true);

            lot.Cars.Add(dadsCar);

            // Call Methods
            brandonCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            dadsCar.MakeEngineNoise();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($" {car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
