
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
        public Diët Diët { get; private set; }
        public AnimalSize Size { get; private set; }

        public Animal(string name, Diët diët, AnimalSize animalSize)
        {
            Name = name;
            Diët = diët;
            Size = animalSize;
        }

        public override string ToString()
        {
            return Name + "  " + Diët.ToString() + "  " + Size.ToString();
        }

        public bool TryEatEachother(Animal animal)
        {
            if ((int)this.Size >= (int)animal.Size)
            {
                if(this.Diët == Diët.Carnivore)
                {
                    return true;
                }
            }
            if ((int)animal.Size >= (int)this.Size)
            {
                if(animal.Diët == Diët.Carnivore)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
