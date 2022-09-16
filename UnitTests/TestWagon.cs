using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestWagon
    {
        [TestMethod]
        [DataRow("cow", Diet.Herbivore, AnimalSize.M)]
        [DataRow("giraffe", Diet.Herbivore, AnimalSize.L)]
        [DataRow("bunny", Diet.Herbivore, AnimalSize.S)]
        [DataRow("tiger", Diet.Carnivore, AnimalSize.M)]
        [DataRow("orca", Diet.Carnivore, AnimalSize.L)]
        [DataRow("snek", Diet.Carnivore, AnimalSize.S)]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAdded_ReturnTrue(string name, Diet diët, AnimalSize size)
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

        [DataRow("orca", Diet.Carnivore, AnimalSize.L, "orca", Diet.Carnivore, AnimalSize.L)]
        [DataRow("orca", Diet.Carnivore, AnimalSize.L, "sheep", Diet.Herbivore, AnimalSize.M)]
        [DataRow("sheep", Diet.Herbivore, AnimalSize.M, "orca", Diet.Carnivore, AnimalSize.L)]
        [DataRow("snek", Diet.Carnivore, AnimalSize.S, "snek", Diet.Carnivore, AnimalSize.S)]
        [DataRow("wolf", Diet.Carnivore, AnimalSize.M, "wolf", Diet.Carnivore, AnimalSize.M)]
        [TestMethod]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAdded_ReturnFalse(string name1, Diet diët1, AnimalSize size1, string name2, Diet diët2, AnimalSize size2)
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

        [DataRow("giraffe", Diet.Herbivore, AnimalSize.L, "giraffe", Diet.Herbivore, AnimalSize.L, "giraffe", Diet.Herbivore, AnimalSize.L)]
        [DataRow("giraffe", Diet.Herbivore, AnimalSize.L, "sheep", Diet.Herbivore, AnimalSize.M, "giraffe", Diet.Herbivore, AnimalSize.L)]
        [DataRow("sheep", Diet.Herbivore, AnimalSize.M, "giraffe", Diet.Herbivore, AnimalSize.L, "sheep", Diet.Herbivore, AnimalSize.M)]
        [TestMethod]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAddedCartFull_Returntrue(string name1, Diet diët1, AnimalSize size1, string name2, Diet diët2, AnimalSize size2, string name3, Diet diët3, AnimalSize size3)
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
