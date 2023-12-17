using NUnit.Framework;

public class ArithmeticShould
{
    [Test]
    public void AddTwoNumbers()
    {
        Assert.AreEqual(4 + 5, 9);
    }

    [Test]
    public void SubstractTwoNumbers()
    {
        Assert.AreEqual(4 - 5, -1);
    }
}
