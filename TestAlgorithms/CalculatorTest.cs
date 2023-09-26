using KlasseTaschenrechner;

namespace TestAlgorithms
{
  public class CalculatorTest
  {
    [Fact]
    public void TestCheckNumberIsPrime()
    {
      var number = 41;
      Assert.Equal(true, Calculator.CheckNumberIsPrime(number));
    }
    [Fact]
    public void TestCheckNumberIsNotPrime()
    {
      var number = 6;
      Assert.Equal(false, Calculator.CheckNumberIsPrime(number));
    }
  }
}
