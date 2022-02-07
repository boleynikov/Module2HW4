using System;

using Module2HW4.Services;
using Module2HW4.Interfaces;
using Module2HW4.Extentions;
namespace Module2HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            ISection safari = new Section();
            var animals = safari.GetAnimals();

            Console.WriteLine($"1. Колличество видов животных: {safari.GetAnimalsCount()}");
            IAnimal[] animalsInfo = animals;
            Console.WriteLine("\n2. В нашем сафари есть такие животные:");
            foreach (var animalInfo in animalsInfo)
            {
                Console.WriteLine(animalInfo);
            }

            IAnimalBehaviour[] animalsBehaviours = animals;
            Console.WriteLine("\n3. Все животные так или иначе могут говорить, ноо...");
            foreach (var animalBehaviour in animalsBehaviours)
            {
                animalBehaviour.MakeSound();
            }

            Console.WriteLine("\n4. Отсортируем животных по имени и дадим погулять:");
            Array.Sort(animals);
            foreach (var animalBehaviour in animalsBehaviours)
            {
                animalBehaviour.Move();
            }
            Console.WriteLine("\n5. Найдём собаку по имени Барон, и узнаем как он говорит:");
            var baron = animals.FindAnimal("Барон");
            baron.MakeSound();
        }
    }
}
