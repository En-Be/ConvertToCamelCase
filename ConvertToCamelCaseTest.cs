using NUnit.Framework;
using System;

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

    [Test]
    public void ConvertsUnderscoreSeperatedToCamelCaseWithFirstCapital()
    {
        string s1 = "What_mate_as_if";
        Assert.AreEqual("WhatMateAsIf", Converter.ToCamelCase(s1));
    }

    [Test]
    public void MustBeInvokedWithInput()
    {
        string s1 = "";
        Assert.Throws<ArgumentException>(() => Converter.ToCamelCase(s1));
    }
}
