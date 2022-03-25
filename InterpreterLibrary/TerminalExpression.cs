namespace InterpreterLibrary;

public class IntegerExpression : TerminalExpression
{
  public string Exp { private get; set; }
  public IntegerExpression(string exp)
  {
    Exp = exp;
  }

  public override int Eval() => int.Parse(Exp);
  public override string Interpret() => Exp;

}