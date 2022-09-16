using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]

        [DataRow("cow", Diet.Herbivore, AnimalSize.M, "cow", Diet.Herbivore, AnimalSize.M, false)]
        [DataRow("giraffe", Diet.Herbivore, AnimalSize.L, "Tiger", Diet.Carnivore, AnimalSize.M, false)]
        [DataRow("Tiger", Diet.Carnivore, AnimalSize.M, "giraffe", Diet.Herbivore, AnimalSize.L, false)]
        [DataRow("cow", Diet.Herbivore, AnimalSize.M, "Tiger", Diet.Carnivore, AnimalSize.M, true)]
        [DataRow("Tiger", Diet.Carnivore, AnimalSize.M, "cow", Diet.Herbivore, AnimalSize.M, true)]
        [DataRow("Tiger", Diet.Carnivore, AnimalSize.M, "Tiger", Diet.Carnivore, AnimalSize.M, true)]
        public void TryEatEachother_TestIfEatEachother_ReturnFalse(string Name1, Diet diët1, AnimalSize size1, string Name2, Diet diët2, AnimalSize size2, bool expectedOutcome)
        {
            //arrange
            Animal animal1 = new Animal(Name1, diët1, size1);
            Animal animal2 = new Animal(Name2, diët2, size2);

            bool expected;

            //act
            expected = animal1.WillEatEachother(animal2);

            //assert
            Assert.AreEqual(expectedOutcome, expected);
        }
    }
}
