using Xunit;
using CalculatorApi.Services;
namespace CalculatorApi.Tests;
public class CalculatorTests
{
    private readonly CalculatorService _service = new CalculatorService();

    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var result = _service.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        var result = _service.Subtract(5, 2);
        Assert.Equal(3, result);
    }
}