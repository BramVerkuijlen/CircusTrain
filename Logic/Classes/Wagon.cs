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
            if ((int) animal.Size <= EmptySpace)
            {
                _animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
