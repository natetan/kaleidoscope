using KaleidoscopeCruiseLines;
using KaleidoscopeCruiseLines.Controllers;
using KaleidoscopeCruiseLines.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace KaleidoscopeCruiseLinesTests
{
    [TestFixture]
    public class PassengersControllerTests
    {
        private Mock<PassengerService> _mockService;
        private PassengersController subject;

        [SetUp]
        public void SetUp()
        {
            _mockService = new Mock<PassengerService>();
            subject = new PassengersController(_mockService.Object);
        }

        [Test]
        public void Get_ReturnsAllPassengers()
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

            _mockService.Setup(stub => stub.getListOfPassengers()).Returns(mockPassengers);

            // Act
            var results = subject.Get();
            
        }
    }
}
