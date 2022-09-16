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
        public Train DivideAnimalsOverTrain(List<Animal> animals)
        {
            Train train = new Train();

            List<Wagon> wagons = new List<Wagon>();

            List<Animal> passive = new List<Animal>();
            List<Animal> agressive = new List<Animal>();

            (passive, agressive) = SortAnimalsOnDiet(animals);

            passive = SortAnimalsBigToSmall(passive);
            agressive = SortAnimalsBigToSmall(agressive);

            wagons = GiveEachAnimalAWagon(agressive);

            wagons = DevideAnimalsOverWagons(wagons, passive);

            train.AddWagonList(wagons);

            return train;
        }

        private (List<Animal> Passive, List<Animal> Agressive) SortAnimalsOnDiet(List<Animal> animals)
        {
           
            List<Animal> passive = new List<Animal>();
            List<Animal> agressive = new List<Animal>();

            foreach (var animal in animals)
            {
                if (animal.Diet == Diet.Carnivore)
                {
                    agressive.Add(animal);
                }

                else
                {
                    passive.Add(animal);
                }
            }

            return (passive, agressive);
        }

        private List<Animal> SortAnimalsBigToSmall(List<Animal> animals)
        {

            return animals.OrderByDescending(e => (int)e.Size).ToList();

            /*
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
            */
        }

        private List<Wagon> GiveEachAnimalAWagon(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();

            foreach (var animal in animals)
            {
                Wagon wagon = new Wagon();
                wagon.TryAddAnimal(animal);
                wagons.Add(wagon);
            }

            return wagons;
        }

        private List<Wagon> DevideAnimalsOverWagons(List<Wagon> wagons, List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                bool filledIn = false;

                for (int i = 0; i < wagons.Count + 1; i++)
                {
                    if (wagons[i].TryAddAnimal(animal))
                    {
                        filledIn = true;
                        break;
                    }
                }

                if (!filledIn)
                {
                    Wagon wagon = new Wagon();
                    wagon.TryAddAnimal(animal);
                    wagons.Add(wagon);
                }
            }
            return wagons;
        }
    }
}
