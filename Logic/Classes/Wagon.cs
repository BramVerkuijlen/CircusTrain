using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Wagon
    {
        public int Size { get; private set; }
        public int EmptySpace
        {
            get
            {
                    return Size - _animals.Sum(e => (int)e.Size);
            }
        }

        private List<Animal> _animals = new List<Animal>();
        public IEnumerable<Animal> Animals
        {
            get { return _animals; }
        }

        public Wagon()
        {
            Size = 10;
        }

        public bool TryAddAnimal(Animal animal)
        {
            if (LookForEmptySpace(animal))
            {
                if (!LookForDiëtConflict(animal))
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

        private bool LookForDiëtConflict(Animal newAnimal)
        {
            foreach (Animal oldAnimal in _animals)
            {
                if (oldAnimal.TryEatEachother(newAnimal))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string result = "wagon";
            foreach (Animal animal in _animals)
            {
                result += ("\n" + animal.ToString());
            }
            return result;
        }
    }
}
