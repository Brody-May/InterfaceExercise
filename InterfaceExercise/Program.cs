using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car();
            car.Make = "Tesla";
            car.Model = "Model 3";
            car.NumberOfWheels = 4;
            car.EngineSize= 4.6;
            
            var truck = new Truck();
            truck.Make = "Toyota";
            truck.Model = "Tundra";
            truck.NumberOfWheels = 4;
            truck.EngineSize = 14.8;
            
            var suv = new SUV();
            suv.Make = "Honda";
            suv.Model = "Passport";
            suv.NumberOfWheels = 4;
            suv.EngineSize = 6;
            
            var vehicles = new List<IVehicle>() {car, truck, suv};
            
            foreach(var vehicle in vehicles) 
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }
        }
    }
}
