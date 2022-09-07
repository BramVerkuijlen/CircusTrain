using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Wagon
    {
        public int Size { get; private set; }
        public int EmptySpace
        {
            get
            {
                int emptySpace = Size;
                foreach (Animal animal in this._animals)
                {
                    emptySpace -= Convert.ToInt32(animal.Size);
                }
                return emptySpace;
            }
        }

        private List<Animal> _animals;
        IEnumerable<Animal> Animals
        {
            get { return _animals; }
        }

        public Wagon()
        {
            Size = 10;
        }

        public bool TryAddAnimal(Animal animal)
        {
            if(LookForEmptySpace(animal))
            {
                if(!LookForBiggerCarnivore(animal))
                {
                    _animals.Add(animal);
                    return true;
                }
            }
            return false;
        }

        private bool LookForEmptySpace(Animal animal)
        {
            if ((int)animal.Size <= EmptySpace)
            {
                return true;
            }
            return false;
        }

        private bool LookForBiggerCarnivore(Animal animal)
        {
            foreach(Animal animal2 in this._animals)
            {
                if((int)animal2.Size >= (int)animal.Size && animal2.Diët == Helper.Diët.Carnivore)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
