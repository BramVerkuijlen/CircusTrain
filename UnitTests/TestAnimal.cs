using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]
        [DataRow("cow", Diët.Herbivore, AnimalSize.M, "cow", Diët.Herbivore, AnimalSize.M)]
        [DataRow("giraffe", Diët.Herbivore, AnimalSize.L, "Tiger", Diët.Carnivore, AnimalSize.M)]
        [DataRow("Tiger", Diët.Carnivore, AnimalSize.M, "giraffe", Diët.Herbivore, AnimalSize.L)]
        public void TryEatEachother_TestIfEatEachother_ReturnFalse(string Name1, Diët diët1, AnimalSize size1, string Name2, Diët diët2, AnimalSize size2)
        {
            //arrange
            Animal animal1 = new Animal(Name1, diët1, size1);
            Animal animal2 = new Animal(Name2, diët2, size2);

            bool expected;

            //act
            expected = animal1.TryEatEachother(animal2);

            //assert
            Assert.IsFalse(expected);
        }

        [TestMethod]
        [DataRow("cow", Diët.Herbivore, AnimalSize.M, "Tiger", Diët.Carnivore, AnimalSize.M)]
        [DataRow("Tiger", Diët.Carnivore, AnimalSize.M, "cow", Diët.Herbivore, AnimalSize.M)]
        [DataRow("Tiger", Diët.Carnivore, AnimalSize.M, "Tiger", Diët.Carnivore, AnimalSize.M)]
        public void TryEatEachother_TestIfEatEachother_ReturnTrue(string Name1, Diët diët1, AnimalSize size1, string Name2, Diët diët2, AnimalSize size2)
        {
            //arrange
            Animal animal1 = new Animal(Name1, diët1, size1);
            Animal animal2 = new Animal(Name2, diët2, size2);
            
            bool expected;

            //act
            expected = animal1.TryEatEachother(animal2);

            //assert
            Assert.IsTrue(expected);
        }
    }
}
