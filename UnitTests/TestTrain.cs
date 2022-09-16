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
            Wagon wagon1 = new Wagon();
            Wagon wagon2 = new Wagon();
            Wagon wagon3 = new Wagon();

            List<Wagon> wagonList = new List<Wagon>();

            wagonList.Add(wagon1);
            wagonList.Add(wagon2);
            wagonList.Add(wagon3);

            //act
            train.AddWagonList(wagonList);

            //assert
            Assert.AreEqual(3, train.Wagons.Count());
        }
    }
}
