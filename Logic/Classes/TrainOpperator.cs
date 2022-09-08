using Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class TrainOpperator
    {
        private List<Animal> Passive;
        private List<Animal> agressive;

        public Train StartAlgorithm(List<Animal> animals)
        {
            Train train = new Train();
            return train;
        }

        private (List<Animal> Passive, List<Animal> Agressive) SortAnimalsOnDiët(List<Animal> animals)
        {
            List<Animal> passive = new List<Animal>();
            List<Animal> agressive = new List<Animal>();

            foreach (var animal in animals)
            {
                if (animal.Diët == Diët.Carnivore)
                {
                    passive.Add(animal);
                }

                else agressive.Add(animal);
            }

            return (passive, agressive);
        }

        private List<Animal> SortAnimalsBigToSMall(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count - 1; i++)
            {
                for (int N = 0; N < animals.Count - i; N++)
                {
                    if (animals[N].Size < animals[N + 1].Size)
                    {
                        animals.Reverse(N, N + 1);
                    }
                }
            }
            return animals;
        }

        private List<Wagon> GiveAnimalWagon(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();

            foreach (var animal in animals)
            {
                Wagon wagon = new Wagon();
                wagon.TryAddAnimal(animal);
            }

            return wagons;
        }

        private List<Wagon> DevideOverWagons(List<Wagon> wagons, List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                for (int i = 0; i < wagons.Count + 1; i++)
                {
                    if(i == wagons.Count)
                    {
                        wagons.Add(new Wagon());
                        wagons[i].TryAddAnimal(animal);
                        break;
                    }

                    if(wagons[i].TryAddAnimal(animal))
                    {
                        wagons[i].TryAddAnimal(animal);
                        break;
                    }
                }
            }

            return wagons;
        }
        
    }
}
