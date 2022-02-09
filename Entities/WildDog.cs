using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    sealed class WildDog : Dog
    {
        public float NailsLenght { get; }
        public WildDog(string name, int age, float weight, float voice, float nailsLenght) : base(name, age, weight, voice)
        {
            NailsLenght = nailsLenght;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} гавкает с громкостью {Voice} децибел");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} быстро бегает, но иногда {NailsLenght}-см когти мешают ему");
        }
    }
}
