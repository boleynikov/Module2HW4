using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    sealed class Lizard : Reptile
    {
        public float TaleLenght { get; }
        public Lizard(string name, int age, float weight, float taleLenght) : base(name, age, weight)
        {
            TaleLenght = taleLenght;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} очень тихий и говорит тс-тс-тс");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} спокойно пресмыкается с хвостом длинной {TaleLenght} см");
        }
    }
}
