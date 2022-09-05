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
        public Train Train { get; private set; }
        private List<Animal> Animals { get; set; }

        public void StartAlgorithm(List<Animal> animals)
        {

        }
        private void SortListAnimals()
        {
            for (int i = 0; i < Animals.Count - 1; i++)
            {
                for (int N = 0; N < Animals.Count - i; N++)
                {
                    if (Animals[N].Size < Animals[N + 1].Size)
                    {
                        Animals.Reverse(N, N + 1);
                    }

                    else if (Animals[N].Size == Animals[N + 1].Size)
                    {
                        if (Animals[N].Diët != Diët.Carnivore && Animals[N + 1].Diët == Diët.Carnivore)
                        {
                            Animals.Reverse(N, N + 1);
                        }
                    }
                }
            }
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
