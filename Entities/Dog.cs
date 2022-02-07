using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    class Dog : Mammal
    {
        public float Voice { get; }
        public Dog(string name, int age, float weight, float voice) : base(name, age, weight)
        {
            Voice = voice;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} гавкает с громкостью {Voice} децибел");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} быстро бегает, как и все собаки");
        }
    }
}
