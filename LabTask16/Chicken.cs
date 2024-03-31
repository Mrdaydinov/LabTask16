using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask16
{
    internal class Chicken : Bird
    {
        public Chicken(string species, int height, int weight) : base(species, height, weight)
        {
        }

        public bool IsRunning { get;  } = true;

        public void Run()
        {
            Console.WriteLine("Run");
        }

    }
}
