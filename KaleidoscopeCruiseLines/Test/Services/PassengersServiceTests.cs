using KaleidoscopeCruiseLines;
using KaleidoscopeCruiseLines.Controllers;
using KaleidoscopeCruiseLines.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace KaleidoscopeCruiseLinesTests
{
    [TestFixture]
    public class PassengersServiceTests
    {
        [SetUp]
        public void SetUp()
        {
            //Set up mock Db Context
        }

        [Test]
        public void getListOfPassengers_ReturnsAllPassengers()
        {
            // Arrange
            var mockPassengers = new List<Passengers>
            {
                new Passengers
                {
                    firstname = "Denny",
                    lastname = "Tran"
                },
                new Passengers
                {
                    firstname = "Yulong",
                    lastname = "Tan"
                },
                new Passengers
                {
                    firstname = "Christine",
                    lastname = "Ta"
                }
            };

            //Mock Database

            // Act


            // Assert
            Assert.AreEqual(results.Count(), 3);

        }
    }
}
