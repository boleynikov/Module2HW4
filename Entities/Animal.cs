using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Interfaces;
namespace Module2HW4.Entities
{
    public abstract class  Animal : IAnimal, IAnimalBehaviour, IComparable<Animal>
    {
        public string Name { get; }

        public int Age { get; }

        public float Weight { get; }
        public Animal(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public int CompareTo(Animal animal)
        {
            if (animal is null) throw new ArgumentException("Это не животное. Не знаю как сравнивать");
            return Name.CompareTo(animal.Name);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} говорит какой-то звук");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name} может ходить/летать/плавать");
        }
        public override string ToString()
        {
            return $"{Name} весом {Age} кг.";
        }
    }
}
