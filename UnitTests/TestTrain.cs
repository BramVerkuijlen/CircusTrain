using Logic.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestTrain
    {
        [TestMethod]
        public void AddWagon_AddOneWagon_ReturnOne()
        {
            //arrange
            Train train = new Train();
            Wagon wagon = new Wagon();

            //act
            train.AddWagon(wagon);

            //assert
            Assert.AreEqual(1, train.Wagons.Count());
        }
    }
}
