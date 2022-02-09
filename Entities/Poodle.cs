using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    sealed class Poodle : HomeDog
    {
        public float SoundVolumeToDie { get; }
        public Poodle(string name, int age, float weight, float voice, string masterName, float soundVolumeToDie) : base(name, age, weight, voice, masterName)
        {
            SoundVolumeToDie = soundVolumeToDie;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Хозяин {MasterName} не разрешает {Name}у гавкать своими {Voice} децибелами");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} двигается аккуратно, ведь если он услышит звук громкостью {SoundVolumeToDie} децибел - то откинет тапки");
        }
    }
}
