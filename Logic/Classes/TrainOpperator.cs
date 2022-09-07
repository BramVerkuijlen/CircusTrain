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
        public Train StartAlgorithm(List<Animal> animals)
        {
            return AddWagonsToTrain(FillAnimalsInWagons(SortListAnimals(animals)), new Train());
        }

        private List<Animal> SortListAnimals(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count - 1; i++)
            {
                for (int N = 0; N < animals.Count - i; N++)
                {
                    if (animals[N].Size < animals[N + 1].Size)
                    {
                        animals.Reverse(N, N + 1);
                    }

                    else if (animals[N].Size == animals[N + 1].Size)
                    {
                        if (animals[N].Diët != Diët.Carnivore && animals[N + 1].Diët == Diët.Carnivore)
                        {
                            animals.Reverse(N, N + 1);
                        }
                    }
                }
            }
            return animals;
        }

        private List<Wagon> FillAnimalsInWagons(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();
            wagons.Add(new Wagon());

            int N = 0;

            for (int i = 0; i < animals.Count;)
            {
                if ((int)animals[i].Size! > wagons[N].Size)
                {
                    if (wagons[N].TryAddAnimal(animals[i]))
                    {
                        i++;
                    }
                    else
                    {
                        wagons.Add(new Wagon());
                        N++;
                    }
                }
            }

            return new List<Wagon>(wagons);
        }

        private Train AddWagonsToTrain(List<Wagon> wagons, Train train)
        {
            foreach (Wagon wagon in wagons)
            {
                train.AddWagon(wagon);
            }
            return train;
        }
    }
}
