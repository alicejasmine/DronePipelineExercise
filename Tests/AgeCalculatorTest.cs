


using NUnit.Framework;

namespace Tests;

[TestFixture]
public class AgeCalculatorTest
{
    [Test]
    public void CalculateAge_ReturnsCorrectAge()
    {
        //Arrange
        var ageCalculator = new AgeCalculator()
        {
            BirthYear = 2000
        };

        //Act
        int result = ageCalculator.CalculateAge(2024);

        //Assert
        Assert.AreEqual(24, result);
    }
}
