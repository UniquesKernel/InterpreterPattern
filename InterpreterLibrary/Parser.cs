using System.Xml;

namespace InterpreterLibrary;

public class Parser
{
  public string Parse(string exp)
  {
    string[] tokens = exp.Split(" ");
    Queue<IExpression> que = new Queue<IExpression>();

    foreach (string token in tokens)
    {
      IExpression left;
      IExpression right;
      BinaryOperatorExpression result;
      switch (token)
      {
        case "+":
          PerformAddition(ref que);
          break;
        case "-":
          PerformSubtraction(ref que);
          break; 
        case "*":
          PerformMultiplication(ref que);
          break;
        case "/":
          PerformDivision(ref que);
          break; 
        default:
          IntegerExpression Exp = new IntegerExpression(token);
          que.Enqueue(Exp);
          break;
      }
    }

    IExpression res = que.Dequeue();
    try
    {
      return res.Interpret();
    }
    catch (ArithmeticException e)
    {
      return e.Message;
    }
  }

  private void PerformAddition(ref Queue<IExpression> que)
  {
    IExpression result = new Plus(que.Dequeue(), que.Dequeue());
    que.Enqueue(result);
  }

  private void PerformSubtraction(ref Queue<IExpression> que)
  {
    IExpression result = new Minus(que.Dequeue(), que.Dequeue());
    que.Enqueue(result);
  }

  private void PerformMultiplication(ref Queue<IExpression> que)
  {
    IExpression result = new Times(que.Dequeue(), que.Dequeue());
    que.Enqueue(result);
  }

  private void PerformDivision(ref Queue<IExpression> que)
  {
    IExpression result = new Div(que.Dequeue(), que.Dequeue());
    que.Enqueue(result);
  }
}
