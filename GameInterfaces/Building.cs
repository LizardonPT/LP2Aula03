using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces
{
    public class Building : IHasValue
    {
        public string Type {get; }
        public float Area {get; }
        public float Value {get; }

        private Building(string type, float area, float value)
        {
            Type = type;
            Area = area;
            Value = value;
        }
        
        private string ToString(string type)
        {
            string type = Console.WriteLine(".{0,-20}.", Type);
        }
    }
}