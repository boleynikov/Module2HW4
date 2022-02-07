using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Entities;
using Module2HW4.Interfaces;
namespace Module2HW4.Services
{
    class Section : ISection
    {
        private readonly Animal[] Animals;
        public Section()
        {
            Animals = new Animal[10];
            Animals[0] = new Lizard("Джефри", 12, 304f, 14f);
            Animals[1] = new Cat("Том", 8, 2500f, 6f);
            Animals[2] = new Poodle("Барон", 5, 600f, 80f, "Дениска", 110f);
            Animals[3] = new HomeDog("Бетховен", 16, 10000f, 150f, "Богдан");
            Animals[4] = new WildDog("Хантер", 13, 9000f, 130f, 50f);
            Animals[5] = new PredatorDog("Белый клык", 7, 7850f, 125f, "Джек Лондон");
            Animals[6] = new Dog("Стрелка", 20, 4500f, 80f);
            Animals[7] = new HomeDog("Ричард", 18, 8600f, 140f, "Владимир");
            Animals[8] = new Poodle("Генерал", 3, 150, 70f, "Сашенька", 90f);
            Animals[9] = new HomeDog("Джон", 21, 5000f, 100, "Гагарин");

        }
        public Animal[] GetAnimals()
        {
            return Animals;
        }

        public int GetAnimalsCount()
        {
            List<Type> types = new List<Type>();
            
            for (int i = 0; i < Animals.Length; i++)
            {
                var animalType = Animals[i].GetType();
                if (!types.Contains(animalType))
                {
                    types.Add(animalType);
                }
            }
            return types.Count;
        }
    }
}
