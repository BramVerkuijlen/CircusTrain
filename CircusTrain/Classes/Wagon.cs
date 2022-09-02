using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Wagon
    {
        public int Size { get; private set; }
        public int EmptySpace { get; private set; }
        public List<Animal> Animals { get; private set; }

        public Wagon(List<Animal> animals)
        {
            Size = 10;
            Animals = animals;

            EmptySpace = Size;
            CalcEmptySpace();
        }

        public void CalcEmptySpace()
        {
            foreach (Animal animal in this.Animals)
            {
                this.EmptySpace = EmptySpace - Convert.ToInt32(animal.Size);
            }
        }
    }
}
