using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3.Vehicles
{
    class Car : Vehicle, ICleanable
    {
        public bool HasRoof {  get; set; }
        public Car(string b, string m, string y, string w, bool hasRoof=true) : base(b, m, y, w)
        {
            HasRoof = hasRoof;
        }
        public override string StartEngine() {
            return "wrom!";
        }
        public override string AtributesInString()
        {
            return base.AtributesInString() + $"Has Roof : {HasRoof}";
        }
        public void Clean()
        {

        }
    }
}
