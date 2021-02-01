using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var lot = new CarLot();
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new car
            //Set the properties for each of the cars


            var myCar = new Car();
            
                myCar.Make = "Chevy";
                myCar.Model = "Cobalt";
                myCar.Year = 2010;
                myCar.EngineNoise = "Weak";
                myCar.HonkNoise = "Beeeeeeep";
                myCar.IsDriveable = true;

            lot.Cars.Add(myCar);
            //method 2
            var yourCar = new Car()
            {
                Make = "Pontiac",
                Model = "G6",
                Year = 2005,
                EngineNoise = "Sports Car",
                HonkNoise = "Brrrrrrp",
                IsDriveable = false,

            };
            lot.Cars.Add(yourCar);
            //method 3
            var otherCar = new Car(2006, "Ford", "f-150", "truck", "breeeep", true);
            lot.Cars.Add(otherCar);



            //Call each of the methods for each car
            myCar.MakeEngineNoise();
            yourCar.MakeEngineNoise();
            otherCar.MakeEngineNoise();

            myCar.MakeHonkNoise();
            yourCar.MakeHonkNoise();
            otherCar.MakeHonkNoise();

            foreach (var vehicle in lot.Cars)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }





            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
           
        }
    }
}
