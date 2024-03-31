using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask16
{
    internal class Bird
    {
        public string Species { get; }
        public int Height { get; }
        public int Weight { get; }

        public Bird(string species, int height, int weight)
        {
            Species = species;
            Height = height;
            Weight = weight;
        }
    }
}
