namespace someapi.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, 1);
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(1, 1 + 1);
    }
}
