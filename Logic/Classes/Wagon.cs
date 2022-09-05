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
                foreach (Animal animal in this.Animals)
                {
                    emptySpace -= Convert.ToInt32(animal.Size);
                }
                return emptySpace;
            }
        }
        public List<Animal> Animals { get; private set; }

        public Wagon()
        {
            Size = 10;
        }
        public bool TryAddAnimal(Animal animal)
        {
            if ((int) animal.Size <= EmptySpace)
            {
                Animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
