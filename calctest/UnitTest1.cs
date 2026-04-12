using static calctest.Program;

namespace calctest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int a = 10;
        int b = 20;
        int expected = 30;

        // Act
        int result = Add2Nos(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test2()
    {
        // Arrange
        int a = -5;
        int b = 15;
        int expected = 20;

        // Act
        int result = Add2Nos(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}