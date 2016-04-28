using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Console.WriteLine("What motor type would you like?");
            Console.WriteLine("1 -> Petrol");
            Console.WriteLine("2 -> Diesel");
            int motorType = Convert.ToInt32(Console.ReadLine());

            if(motorType > factory.motorTypes.Count)
            {
                Console.WriteLine("Invalid value, try again");
                motorType = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("How much fuel should I use?");
            Int32 fuel = Convert.ToInt32(Console.ReadLine());

            
            IMotor CurrentMotor = factory.CreateInstance(motorType);

            if (CurrentMotor == null)
                return;

            Console.WriteLine(CurrentMotor.InjectFuel(fuel));
            Console.WriteLine(CurrentMotor.UseFuel());

            Console.ReadLine();
        }
    }
}
