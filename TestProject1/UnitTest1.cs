namespace TestProject1;

using ConsoleApp1;

public class Tests
{
    [Test]
    public void BiggestNumberTest()
    {
        Assert.IsFalse(Program.BiggestNumber(2, 5));
        Assert.IsTrue(Program.BiggestNumber(5, 2));
    }

    [Test]
    public void MToSmTest()
    {
        Assert.AreNotEqual(Program.MToSm(100), 100);
        Assert.AreEqual(Program.MToSm(1), 100);
    }


    [Test]
    public void DateIsExistTest()
    {
        Assert.IsFalse(Program.DateIsExist("32.07.2003"));
        Assert.IsTrue(Program.DateIsExist("26.07.2003"));
    }

    [Test]
    public void AuthorizeTest()
    {
        Assert.IsTrue(Program.Authorize("bvv", "123",
            new Dictionary<string, string> { { "bvv", "123" }, { "kns", "321" } }));
        Assert.IsFalse(Program.Authorize("bvv", "123",
            new Dictionary<string, string> { { "asd", "123" }, { "kns", "321" } }));
    }

    [Test]
    public void RegisterTest()
    {
        Assert.IsTrue(Program.Register("lol", "123", "vovaborkovskij@gmail.com", "26.07.2003",
            new Dictionary<string, string> { { "bvv", "123" }, { "kns", "321" } }));
        Assert.IsFalse(Program.Register("bvv", "123", "vovaborkovskij@gmail.com", "26.07.2003",
            new Dictionary<string, string> { { "bvv", "123" }, { "kns", "321" } }));
        Assert.IsFalse(Program.Register("lol", "123", "vovaborkovskijgmail.com", "26.07.2003",
            new Dictionary<string, string> { { "bvv", "123" }, { "kns", "321" } }));
        Assert.IsFalse(Program.Register("lol", "123", "vovaborkovskij@gmail.com", "32.07.2003",
            new Dictionary<string, string> { { "bvv", "123" }, { "kns", "321" } }));
    }
}