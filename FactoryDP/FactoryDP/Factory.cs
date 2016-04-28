using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class Factory
    {
        public IMotor CreateInstance(int motorTypeKey)
        {
            IMotor output;

            string motorType = motorTypes[motorTypeKey];

            if (motorType == "DieselMotor")
                return output = new DieselMotor() { Brand = "BMW", Power = 200, Speed = 300 };

            if (motorType == "PetrolMotor")
                return output = new PetrolMotor() { Brand = "VW", Power = 90, Speed = 200 };

            return output = null;
        }

        public Dictionary<int, string> motorTypes = new Dictionary<int, string>()
        {
            {1,"PetrolMotor" },
            {2,"DieselMotor" }
        };
        
    }
}
