using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class TestTrainOpperator
    {
        [TestMethod]
        public void DevideAnimalsOverTrain_DevideAnimalsOverTrain_ReturnTrain()
        {
            //arrange test
            TrainOpperator trainOpperator = new TrainOpperator();

            Train train = new Train();

            Animal animal1 = new Animal("cow", Diët.Herbivore, AnimalSize.M);
            Animal animal2 = new Animal("giraffe", Diët.Herbivore, AnimalSize.L);
            Animal animal3 = new Animal("bunny", Diët.Herbivore, AnimalSize.S);
            Animal animal4 = new Animal("tiger", Diët.Carnivore, AnimalSize.M);
            Animal animal5 = new Animal("orca", Diët.Carnivore, AnimalSize.L);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);

            //arrange expected outcome

            Train expectedTrain = new Train();

            Wagon expectedWagon1 = new Wagon();
            Wagon expectedWagon2 = new Wagon();
            Wagon expectedWagon3 = new Wagon();

            expectedWagon1.TryAddAnimal(animal5);

            expectedWagon2.TryAddAnimal(animal4);
            expectedWagon2.TryAddAnimal(animal2);

            expectedWagon3.TryAddAnimal(animal1);
            expectedWagon3.TryAddAnimal(animal3);

            expectedTrain.AddWagon(expectedWagon1);
            expectedTrain.AddWagon(expectedWagon2);
            expectedTrain.AddWagon(expectedWagon3);

            //act

            train = trainOpperator.DevideAnimalsOverTrain(animals);

            //assert

            Assert.AreEqual(3, train.Wagons.Count());
            CollectionAssert.Equals(expectedTrain, train);
        }
    }
}
