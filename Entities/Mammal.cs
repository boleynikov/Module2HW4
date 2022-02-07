using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    public abstract class Mammal: Animal
    {
        public Mammal(string name, int age, float weight) : base(name, age, weight)
        {

        }
    }
}
