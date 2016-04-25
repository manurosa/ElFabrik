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
            Console.WriteLine("What motor type would you like?");
            string motorType = Console.ReadLine();

            Console.WriteLine("How much fuel should I use?");
            Int32 fuel = Convert.ToInt32(Console.ReadLine());

            Factory factory = new Factory();

            IMotor DieselMotor = factory.CreateInstance(motorType);

            if (DieselMotor == null)
                return;

            Console.WriteLine(DieselMotor.InjectFuel(fuel));
            Console.WriteLine(DieselMotor.UseFuel());

            Console.ReadLine();
        }
    }
}
