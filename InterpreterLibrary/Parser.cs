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
          left = que.Dequeue();
          right = que.Dequeue();
          result = new Plus(left, right);
          que.Enqueue(result);
          break;
        case "-":
          left = que.Dequeue();
          right = que.Dequeue();
          result = new Minus(left, right);
          que.Enqueue(result);
          break; 
        case "*":
          left = que.Dequeue();
          right = que.Dequeue();
          result = new Times(left, right);
          que.Enqueue(result);
          break;
        case "/":
          left = que.Dequeue();
          right = que.Dequeue();
          result = new Div(left, right);
          que.Enqueue(result);
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
}