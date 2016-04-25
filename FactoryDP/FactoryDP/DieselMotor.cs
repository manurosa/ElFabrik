using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class DieselMotor : IMotor
    {
        public string Brand { get; set; }

        public int Power { get; set; }

        public int Speed { get; set; }

        public string InjectFuel(int ml)
        {
            return string.Format("DieselMotor: {0} ml of diesel injected", ml);
        }

        public string UseFuel()
        {
            return DoCombustion();
        }

        private string DoCombustion()
        {
            return "DieselMotor: Combustion Made";
        }
    }
}
