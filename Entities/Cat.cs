using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    sealed class Cat : Mammal
    {
        public float MustacheLenght { get; }
        public Cat(string name, int age, float weight, float mustacheLenght) : base(name, age, weight)
        {
            MustacheLenght = mustacheLenght;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит Мяууууууу");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} ходит как и все, но иногда {MustacheLenght}-ый хвост мешает");
        }
    }
}
