using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask16
{
    internal class Eagle : Bird
    {
        public Eagle(string species, int height, int weight) : base(species, height, weight)
        {
        }

        public bool IsFly { get; } = true;


        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
