using System.ComponentModel.DataAnnotations;
using RentalManagement.ClassLibrary;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RentMethod_Test()
        {
            //Arrange
            Car car = new Car("Opel Corsa", 179);
            Horse horse = new Horse("King", "Haflinger");

            //Act
            car.Rent();
            horse.Rent();

            //Assert
            Assert.That(car.IsAvailable, Is.False, "Car did not get rented");
            Assert.That(horse.IsAvailable, Is.False, "Horse did not get rented");
        }

        [Test]
        public void TriggerNeedsService_Test()
        {
            //Arrange
            Car car = new Car("Opel Corsa", 179);

            //Act
            car.Drive(10000);

            //Assert
            Assert.That(car.NeedsService, Is.True, "NeedsService didn't become true");
            Assert.That(car.IsAvailable, Is.False, "IsAvailable didnt become false");
        }

        [Test]
        public void ResetNeedForService_Test()
        {
            //Arrange
            Car car = new Car("Opel Corsa", 179);

            //Act
            car.Drive(10000);
            car.ResetNeedForService();

            //Assert
            Assert.That(car.NeedsService, Is.False, "NeedsService didn't become false");
        }


    }
}