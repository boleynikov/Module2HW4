using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Entities
{
    class HomeDog : Dog
    {
        public string MasterName { get; }
        public HomeDog(string name, int age, float weight, float voice, string masterName) : base(name, age, weight, voice)
        {
            MasterName = masterName;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Хозяин {MasterName} не разрешает {Name}у гавкать своими {Voice} децибелами");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} быстро бегает, пока {MasterName} не видит");
        }
    }
}
