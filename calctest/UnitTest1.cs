using  calc;

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
        int result =Program.Add2Nos(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    
}