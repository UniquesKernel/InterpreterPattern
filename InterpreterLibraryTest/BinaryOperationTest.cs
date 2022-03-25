using System;
using InterpreterLibrary;
using NUnit.Framework;

namespace InterpreterLibraryTest;

[TestFixture]
public class BinaryOperationTest
{
  private BinaryOperatorExpression _uut;
  private IntegerExpression LeftExpression;
  private string _leftValue = "5";
  private IntegerExpression RightExpression;
  private string _rightValue = "2";

  [SetUp]
  public void SetUp()
  {
    LeftExpression = new IntegerExpression(_leftValue);
    RightExpression = new IntegerExpression(_rightValue);
  }

  [Test]
  public void PlusOperatorEvaluatesToIntegerSumOfLeftAndRightExpression_ReturnsInteger()
  {
    _uut = new Plus(LeftExpression, RightExpression);
    Assert.That(_uut.Eval(), Is.EqualTo(7));
  }

  [Test]
  public void PlusOperatorInterpretToStringOfSumOfLeftAndRightExpression_ReturnsString()
  {
    _uut = new Plus(LeftExpression, RightExpression);
    Assert.That(_uut.Interpret(), Is.EqualTo("7"));
  }

  [Test]
  public void MinusOperatorEvaluatesToIntegerSumOfLeftAndRightExpression_ReturnsInteger()
  {
    _uut = new Minus(LeftExpression, RightExpression);
    Assert.That(_uut.Eval(), Is.EqualTo(3));
  }

  [Test]
  public void MinusOperatorInterpretToStringOfSumOfLeftAndRightExpression_ReturnsString()
  {
    _uut = new Minus(LeftExpression, RightExpression);
    Assert.That(_uut.Interpret(), Is.EqualTo("3"));
  }

  [Test]
  public void MultiplicationOperatorEvaluatesToIntegerSumOfLeftAndRightExpression_ReturnsInteger()
  {
    _uut = new Times(LeftExpression, RightExpression);
    Assert.That(_uut.Eval(), Is.EqualTo(10));
  }

  [Test]
  public void MultiplicationOperatorInterpretToStringOfSumOfLeftAndRightExpression_ReturnsString()
  {
    _uut = new Times(LeftExpression, RightExpression);
    Assert.That(_uut.Interpret(), Is.EqualTo("10"));
  }

  [Test]
  public void DivisionOperatorEvaluatesToIntegerSumOfLeftAndRightExpression_ReturnsInteger()
  {
    _uut = new Div(LeftExpression, RightExpression);
    Assert.That(_uut.Eval(), Is.EqualTo(2));
  }

  [Test]
  public void DivisionOperatorInterpretToStringOfSumOfLeftAndRightExpression_ReturnsString()
  {
    _uut = new Div(LeftExpression, RightExpression);
    Assert.That(_uut.Interpret(), Is.EqualTo("2"));
  }

  [Test]
  public void DivisionOperatorEval_ThrowsArithmeticErrorOnDivideByZeroError()
  {
    RightExpression = new IntegerExpression("0");
    _uut = new Div(LeftExpression, RightExpression);
    Assert.Throws<ArithmeticException>(() => _uut.Eval());
  }

  [Test]
  public void DivisionOperatorInterpret_ThrowsArithmeticErrorOnDivideByZeroError()
  {
    RightExpression = new IntegerExpression("0");
    _uut = new Div(LeftExpression, RightExpression);
    Assert.Throws<ArithmeticException>(() => _uut.Interpret());
  }



}