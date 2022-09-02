using CircusTrain.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Animal
    {
        public string Name { get; private set; }
        public Diët Carnivorous { get; private set; }
        public AnimalSize Size { get; private set; }

        public Animal(string name, Diët diët, AnimalSize animalSize)
        {
            Name = name;
            Carnivorous = diët;
            Size = animalSize;
        }

        public override string ToString()
        {
            return Name + "  " + Carnivorous.ToString() + "  " + Size.ToString();
        }
    }
}
