namespace WebAppNM2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCar()
        {
            // Arrange
            Car newCar = new Car();

            // Act
            newCar.Name = "toto";

            // Assert
            Assert.That(newCar.Name, Is.Not.Null);
        }
    }
}