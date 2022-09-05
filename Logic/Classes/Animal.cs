
using Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
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
    }
}
