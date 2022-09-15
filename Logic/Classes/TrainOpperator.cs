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
        public Train DevideAnimalsOverTrain(List<Animal> animals)
        {
            Train train = new Train();

            List<Wagon> wagons = new List<Wagon>();

            List<Animal> passive = new List<Animal>();
            List<Animal> agressive = new List<Animal>();

            (passive, agressive) = SortAnimalsOnDiët(animals);

            passive = SortAnimalsBigToSmall(passive);
            agressive = SortAnimalsBigToSmall(agressive);

            wagons = GiveAnimalWagon(agressive);

            wagons = DevideOverWagons(wagons, passive);

            train = AddWagonsToTrain(train, wagons);

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
                    agressive.Add(animal);
                }

                else passive.Add(animal);
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

        private List<Wagon> GiveAnimalWagon(List<Animal> animals)
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

        private Train AddWagonsToTrain(Train train, List<Wagon> wagons)
        {
            foreach (var wagon in wagons)
            {
                train.AddWagon(wagon);
            }
            return train;
        }
        
    }
}
