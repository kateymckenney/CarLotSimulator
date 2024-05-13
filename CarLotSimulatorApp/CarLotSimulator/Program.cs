using System;

namespace CarLotSimulator
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //TODO

            //DONE Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var firstCar = new Car();

            firstCar.Make = "Toyota";
            firstCar.Model = "Tacoma";
            firstCar.Year = 2012;
            firstCar.EngineNoise = "vroom";
            firstCar.HonkNoise = "honk";
            firstCar.IsDrivable = true;

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var secondCar = new Car()
            {
                Make = "Volkswagon",
                Model = "Westfalia",
                Year = 1990,
                EngineNoise = "putter",
                HonkNoise = "beep",
                IsDrivable = false,

            };

            var thirdCar = new Car()
            {
                Make = "Ford",
                Model = "T-Bucket",
                Year = 1926,
                EngineNoise = "rumble",
                HonkNoise = "ah-oo-ga",
                IsDrivable = true,

            };

            var fourthCar = new Car()
            {
                Make = "Tesla",
                Model = "Y",
                Year = 2021,
                EngineNoise = "zoom",
                HonkNoise = "honk",
                IsDrivable= true,
            };


            firstCar.MakeEngineNoise(firstCar.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
