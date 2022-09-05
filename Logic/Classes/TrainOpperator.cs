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
        public void StartAlgorithm(List<Animal> animals)
        {

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

        private void FillWagon()
        {
            Wagon wagon = new Wagon();



        }

        private void AddWagonToTrain()
        {

        }
    }
}
