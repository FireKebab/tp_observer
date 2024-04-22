namespace Object.Tests;
using Moq;
public class Tests

{
    public Subject subject;
    [SetUp]
    public void Setup()
    {
        subject= new Subject();
    }

    [Test]
    public void TestGetValue()
    {

        string result = subject.GetValue();
        Assert.AreEqual("valeur", result);
        Assert.Pass();
    }

    [Test]

    public void TestSetValue()
    {
        string expectedValue = "TestValue";

    // Act
        subject.SetValue(expectedValue);

    // Assert
         Assert.AreEqual(expectedValue, subject.GetValue());
    }

    [Test]

    public void TestIsRegistered()
    {
        bool result = subject.IsRegistered(new Observer());
        Assert.IsTrue(result);
    }

    [Test]
    public void TestRegisterObserver()
    {
        // Arrange
        IObserver observer = new Mock<IObserver>().Object;

        // Act
        subject.RegisterObserver(observer);

        Assert.Pass();
}

    [Test]
    public void TestUnRegisterObserver()
{
        // Arrange
        IObserver observer = new Mock<IObserver>().Object;

        // Act
        subject.UnRegisterObserver(observer);

        Assert.Pass();
}
}
