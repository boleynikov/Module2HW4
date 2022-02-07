using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    class PredatorDog : HomeDog
    {
        public PredatorDog(string name, int age, float weight, float voice, string masterName) : base(name, age, weight, voice, masterName)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} пытается вести себя тихо, потому что любит охотится");
        }
    }
}
