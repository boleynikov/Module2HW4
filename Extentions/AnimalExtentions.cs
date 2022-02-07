using Module2HW4.Entities;
namespace Module2HW4.Extentions
{
    public static class AnimalExtentions
    {
        public static Animal FindAnimal(this Animal[] animals, string name, float? weight = null)
        {
            if (weight == null)
            {
                foreach (var animal in animals)
                {
                    if (animal.Name == name)
                    {
                        return animal;
                    }
                }
            }
            else
            {
                foreach (var animal in animals)
                {
                    if (animal.Name == name && animal.Weight == weight)
                    {
                        return animal;
                    }
                }
            }
            return null;
        }
    }
}
