using Xunit;
using playing;

public class testing
{
  [Fact]
  public void PassingADDtest()
  {
    Assert.Equal(4, Program.ADD(2,2));
  }

}