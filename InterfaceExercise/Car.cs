using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car() 
        { 
        
        }

        public double EngineSize { get; set; } = 4.6;
        public int NumberOfWheels { get; set; } = 4;
        public string Model { get; set; } = "Model 3";
        public string Make { get; set; } = "Tesla";
        public string CompanyName { get; set; } = "SpaceX";
        public string Logo { get; set; } = "Cross-section of an electric motor";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Change gears first please to park");
            }
        }

        public void Reverse()
        {
            if(HasChangedGears == true) 
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else 
            {
                Console.WriteLine("Change gears first please to reverse");
            }

        }
        public void ChangeGears(bool isChanged) 
        { 
            HasChangedGears= isChanged;
        }
    }
}
