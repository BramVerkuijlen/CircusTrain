using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]
        public void TryEatEachother_TestIfEatEachother_ReturnFalse()
        {
            //arrange
            Animal cow = new Animal("cow", Diët.Herbivore, AnimalSize.M);
            Animal horse = new Animal("horse", Diët.Herbivore, AnimalSize.L);

            bool expected;

            //act
            expected = cow.TryEatEachother(horse);

            //assert
            Assert.IsFalse(expected);
        }

        [TestMethod]
        [DataRow("cow", Diët.Herbivore, AnimalSize.M, "Tiger", Diët.Carnivore, AnimalSize.M)]
        [DataRow("Tiger", Diët.Carnivore, AnimalSize.M, "cow", Diët.Herbivore, AnimalSize.M)]
        [DataRow("Tiger", Diët.Carnivore, AnimalSize.M, "Tiger", Diët.Carnivore, AnimalSize.M)]
        [DataRow("giraffe", Diët.Herbivore, AnimalSize.L, "Tiger", Diët.Carnivore, AnimalSize.M)]
        public void TryEatEachother_TestIfEatEachother_ReturnTrue(string Name1, Diët diët1, AnimalSize size1, string Name2, Diët diët2, AnimalSize size2)
        {
            //arrange
            Animal cow = new Animal(Name1, diët1, size1);
            Animal tiger = new Animal(Name2, diët2, size2);
            
            bool expected;

            //act
            expected = cow.TryEatEachother(tiger);

            //assert
            Assert.IsTrue(expected);
        }
    }
}
