using System;
using InterpreterLibrary;
using NUnit.Framework;

namespace InterpreterLibraryTest;

[TestFixture]
public class ParserTest
{
  private Parser _uut;

  [SetUp]
  public void SetUp()
  {
    _uut = new Parser();
  }

  [Test]
  public void ParserCorrectlyParsesIntegerExpression()
  {
    Assert.That(_uut.Parse("5"), Is.EqualTo("5"));
  }

  [TestCase("1 2 +", "3")]
  [TestCase("1 5 +", "6")]
  [TestCase("1 2 -", "-1")]
  [TestCase("5 1 -", "4")]
  [TestCase("100 50 -", "50")]
  [TestCase("2 2 *", "4")]
  [TestCase("2 0 *", "0")]
  [TestCase("10 10 *", "100")]
  [TestCase("10 2 /", "5")]
  [TestCase("5 1 /", "5")]
  [TestCase("5 5 + 5 +", "15")]
  public void ParserCorrectlyParsesIntegerExpression(string exp, string res)
  {
    Assert.That(_uut.Parse(exp), Is.EqualTo(res));
  }

  [Test]
  public void ParserCatchesArimethicExceptionAndReturnMessage()
  {
    string exp = "5 0 /";
    Assert.That(_uut.Parse(exp), Is.EqualTo("Division by 0, is not allowed"));
  }
}