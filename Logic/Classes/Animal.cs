
using Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Animal
    {
        public string Name { get; private set; }
        public Diet Diet { get; private set; }
        public AnimalSize Size { get; private set; }

        public Animal(string name, Diet diët, AnimalSize animalSize)
        {
            Name = name;
            Diet = diët;
            Size = animalSize;
        }

        public override string ToString()
        {
            return Name + "  " + Diet.ToString() + "  " + Size.ToString();
        }

        public bool TryEatEachother(Animal animal)
        {
            if (this.Diet == Diet.Carnivore && (int)this.Size >= (int)animal.Size)
            {
               return true;
            }
            if (animal.Diet == Diet.Carnivore && (int)animal.Size >= (int)this.Size)
            {
                return true;
            }
            return false;
        }
    }
}
