using NUnit.Framework;

public class TestSample
{
    [Test]
    public void Passed()
    {
        Assert.AreEqual(true, true);
    }
    
    [Test]
    public void Failed()
    {
        Assert.AreEqual(true, false);
    }
}