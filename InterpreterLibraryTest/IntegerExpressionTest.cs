using InterpreterLibrary;
using NUnit.Framework;

namespace InterpreterLibraryTest;

[TestFixture]
public class IntegerExpressionTest
{
  private IntegerExpression _uut;
  private string _value = "5";

  [SetUp]
  public void SetUp()
  {
    _uut = new IntegerExpression(_value);
  }

  [Test]
  public void IntegerExpressionEvaluateToSelf_ReturnIntegerType()
  {
    Assert.That(_uut.Eval(), Is.EqualTo(int.Parse(_value)));
  }

  [Test]
  public void IntegerExpressionInterpretToSelf_ReturnStringType()
  {
    Assert.That(_uut.Interpret(), Is.EqualTo(_value));
  }
}