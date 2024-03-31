using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask16
{
    internal class Duck : Bird
    {
        public Duck(string species, int height, int weight) : base(species, height, weight)
        {
        }

        public bool IsSwimming { get; } = true; 

        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
