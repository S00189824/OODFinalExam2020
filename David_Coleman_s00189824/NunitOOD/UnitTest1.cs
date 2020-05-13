using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using David_Coleman_s00189824;

namespace NunitOOD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone p1 = new Phone();
            p1.Price = 100;

            //Act
            p1.IncreasePrice(20);

            //Assert
            Assert.AreEqual(p1.Price, 120);
        }
    }
}
