using NUnit.Framework;


public class Tests
{
    [Test]
    public void ConvertsDashSeperatedToCamelCase()
    {
        string s1 = "hello-there-you";
        Assert.AreEqual("helloThereYou", Converter.ToCamelCase(s1));

        string s2 = "why-hello-dear";
        Assert.AreEqual("whyHelloDear", Converter.ToCamelCase(s2));
    }

    [Test]
    public void ConvertsDashSeperatedToCamelCaseWithFirstCapital()
    {
        string s1 = "Hiya-luv";
        Assert.AreEqual("HiyaLuv", Converter.ToCamelCase(s1));
    }

    [Test]
    public void ConvertsUnderscoreSeperatedToCamelCase()
    {
        string s1 = "allo_mate";
        Assert.AreEqual("alloMate", Converter.ToCamelCase(s1));
    }
}
