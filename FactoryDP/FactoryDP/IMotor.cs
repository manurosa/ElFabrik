using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    interface IMotor
    {
        string Brand { get; set; }
        int Power { get; set; }
        int Speed { get; set; }

        string UseFuel();
        string InjectFuel(int ml);
    }
}
