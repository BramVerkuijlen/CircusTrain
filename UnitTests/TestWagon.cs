using Logic.Classes;
using Logic.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestWagon
    {
        [TestMethod]
        public void TryAddAnimal_TryAddAnimalAndCheckIfAdded_ReturnTrue()
        {
            //arrange
            Wagon wagon = new Wagon();
            Animal cow = new Animal("cow", Diët.Herbivore, AnimalSize.M);

            bool expected;

            //act
            expected = wagon.TryAddAnimal(cow);

            //assert
            Assert.IsTrue(expected);
            Assert.AreEqual(1, wagon.Animals.Count());
        }
    }
}
