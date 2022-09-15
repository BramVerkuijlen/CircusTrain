using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestWagon
    {
        [TestMethod]
        [DataRow("cow", Diët.Herbivore, AnimalSize.M)]
        [DataRow("giraffe", Diët.Herbivore, AnimalSize.L)]
        [DataRow("bunny", Diët.Herbivore, AnimalSize.S)]
        [DataRow("tiger", Diët.Carnivore, AnimalSize.M)]
        [DataRow("orca", Diët.Carnivore, AnimalSize.L)]
        [DataRow("snek", Diët.Carnivore, AnimalSize.S)]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAdded_ReturnTrue(string name, Diët diët, AnimalSize size)
        {
            //arrange
            Wagon wagon = new Wagon();
            Animal animal = new Animal(name, diët, size);

            bool expected;

            //act
            expected = wagon.TryAddAnimal(animal);

            //assert
            Assert.IsTrue(expected);
            Assert.AreEqual(1, wagon.Animals.Count());
        }

        [DataRow("orca", Diët.Carnivore, AnimalSize.L, "orca", Diët.Carnivore, AnimalSize.L)]
        [DataRow("orca", Diët.Carnivore, AnimalSize.L, "sheep", Diët.Herbivore, AnimalSize.M)]
        [DataRow("sheep", Diët.Herbivore, AnimalSize.M, "orca", Diët.Carnivore, AnimalSize.L)]
        [DataRow("snek", Diët.Carnivore, AnimalSize.S, "snek", Diët.Carnivore, AnimalSize.S)]
        [DataRow("wolf", Diët.Carnivore, AnimalSize.M, "wolf", Diët.Carnivore, AnimalSize.M)]
        [TestMethod]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAdded_ReturnFalse(string name1, Diët diët1, AnimalSize size1, string name2, Diët diët2, AnimalSize size2)
        {
            //arrange
            Wagon wagon = new Wagon();
            Animal animal1 = new Animal(name1, diët1, size1);
            Animal animal2 = new Animal(name2, diët2, size2);

            bool expected;

            wagon.TryAddAnimal(animal1);

            //act
            expected = wagon.TryAddAnimal(animal2);

            //assert
            Assert.IsFalse(expected);
        }

        [DataRow("giraffe", Diët.Herbivore, AnimalSize.L, "giraffe", Diët.Herbivore, AnimalSize.L, "giraffe", Diët.Herbivore, AnimalSize.L)]
        [DataRow("giraffe", Diët.Herbivore, AnimalSize.L, "sheep", Diët.Herbivore, AnimalSize.M, "giraffe", Diët.Herbivore, AnimalSize.L)]
        [DataRow("sheep", Diët.Herbivore, AnimalSize.M, "giraffe", Diët.Herbivore, AnimalSize.L, "sheep", Diët.Herbivore, AnimalSize.M)]
        [TestMethod]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAddedCartFull_Returntrue(string name1, Diët diët1, AnimalSize size1, string name2, Diët diët2, AnimalSize size2, string name3, Diët diët3, AnimalSize size3)
        {
            //arrange
            Wagon wagon = new Wagon();
            Animal animal1 = new Animal(name1, diët1, size1);
            Animal animal2 = new Animal(name2, diët2, size2);
            Animal animal3 = new Animal(name3, diët3, size3);

            bool expected;

            wagon.TryAddAnimal(animal1);
            wagon.TryAddAnimal(animal2);

            //act
            expected = wagon.TryAddAnimal(animal3);

            //assert
            Assert.IsFalse(expected);
        }
    }
}
