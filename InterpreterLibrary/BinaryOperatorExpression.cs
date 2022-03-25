namespace InterpreterLibrary;

public abstract class BinaryOperatorExpression : NonTerminalExpression
{
  public IExpression LeftExpression { get; set; }
  public IExpression RightExpression { get; set; }
}

public class Plus : BinaryOperatorExpression
{
  public Plus(IExpression leftExpression, IExpression rightExpression)
  {
    LeftExpression = leftExpression;
    RightExpression = rightExpression;
  }

  public override int Eval() => LeftExpression.Eval() + RightExpression.Eval();
  public override string Interpret() => Eval().ToString();

}

public class Minus : BinaryOperatorExpression
{
  public Minus(IExpression leftExpression, IExpression rightExpression)
  {
    LeftExpression = leftExpression;
    RightExpression = rightExpression;
  }

  public override int Eval() => LeftExpression.Eval() - RightExpression.Eval();
  public override string Interpret() => Eval().ToString();

}
public class Times : BinaryOperatorExpression
{
  public Times(IExpression leftExpression, IExpression rightExpression)
  {
    LeftExpression = leftExpression;
    RightExpression = rightExpression;
  }

  public override int Eval() => LeftExpression.Eval() * RightExpression.Eval();
  public override string Interpret() => Eval().ToString();

}

public class Div : BinaryOperatorExpression
{
  public Div(IExpression leftExpression, IExpression rightExpression)
  {
    LeftExpression = leftExpression;
    RightExpression = rightExpression;
  }

  public override int Eval()
  {
    if (RightExpression.Eval() == 0)
    {
      throw new ArithmeticException("Division by 0, is not allowed");
    }

    return LeftExpression.Eval() / RightExpression.Eval();
  }

  public override string Interpret() => Eval().ToString();

}