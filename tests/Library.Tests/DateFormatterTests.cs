using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using NUnit.Framework;
using Library;

namespace Library;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormatTest()
    {
        string date = "07/09/2022";
        Assert.AreEqual("2022-09-07", DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void WrongFormatTest()
    {
        string date = "7.9.2022";
        Assert.AreNotEqual("2022-09-07", DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void BlankDateTest()
    {
        string date = "";
        Assert.AreEqual("BlankDate", DateFormatter.ChangeFormat(date));
    }

}