using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Entities;
namespace Module2HW4.Interfaces
{
    public interface ISection
    {
        int GetAnimalsCount();

        Animal[] GetAnimals();
    }
}
