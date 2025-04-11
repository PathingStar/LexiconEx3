using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3.Vehicles
{
    class Truck :Vehicle , ICleanable
    {
        double cargoCapacity;
        public double CargoCapacity {get => cargoCapacity; 
            set
            {
                if (value > 0)
                    cargoCapacity = value;
                else throw new AggregateException("Weight must be positive");
            } 
        }
        public Truck(string b, string m, string y, string w,string c) : base(b, m, y, w)
        {
            CargoCapacity=double.Parse(c);
        }
        public override string StartEngine()
        {
            return "Wrom!!!";
        }
        public override string AtributesInString()
        {
            return base.AtributesInString() + $"Cargo Capacity: {CargoCapacity}";
        }
        public void Clean()
        {

        }
    }
}
