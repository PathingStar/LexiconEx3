using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3.Vehicles
{
    class ElectricScooter : Vehicle
    {
        double batteryRange;
        public double BatteryRange { get => batteryRange; set
            {
                if (value > 0)
                    batteryRange = value;
                else throw new AggregateException("Weight must be positive");
            }
        }

        public ElectricScooter(string b, string m, string y, string w,string bR) : base(b, m, y, w)
        {
            BatteryRange = double.Parse( bR);
        }

        public override string StartEngine()
        {
            return "eeeee";
        }

        public override string AtributesInString()
        {
            return base.AtributesInString() +$"Battery Range: {batteryRange}";
        }
    }
}
