using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class PetrolMotor : IMotor
    {
        public string Brand { get; set; }

        public int Power { get; set; }

        public int Speed { get; set; }

        public string InjectFuel(int ml)
        {
            return string.Format("PetrolMotor: {0} ml of petrol injected", ml);
        }

        public string UseFuel()
        {
            return DoExplosion();
        }

        private string DoExplosion()
        {
            return "PetrolMotor: Explosion Made";
        }
    }
}
