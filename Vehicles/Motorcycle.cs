using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3.Vehicles
{
    class Motorcycle: Vehicle
    {
        public bool HasSidecar {  get; set; }
        public Motorcycle(string b, string m, string y, string w, bool hasSidecar=false) : base(b, m, y, w)
        {
            HasSidecar = hasSidecar;
        }
        public override string StartEngine()
        {
            return "wrom wrom!";
        }
        public override string AtributesInString()
        {
            return base.AtributesInString() + $"Has Sidecar: {HasSidecar}";
        }
    }
}
