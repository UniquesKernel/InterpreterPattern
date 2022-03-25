namespace InterpreterLibrary;

public abstract class TerminalExpression : IExpression
{
  public string Exp { private set; get; }
  public abstract int Eval();
  public abstract string Interpret();
}

public abstract class NonTerminalExpression : IExpression
{
  public abstract int Eval();
  public abstract string Interpret();
}

