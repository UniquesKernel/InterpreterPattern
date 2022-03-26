using InterpreterLibrary;

namespace Interpreter;

public class program
{
 public static void Main()
  {
    Parser parser = new Parser();

    Console.WriteLine("Please Enter enter an expression");
    Console.WriteLine("Please only use integer numbers");
    Console.WriteLine("and follow the format num num operator num operator");
    Console.WriteLine("Example: 1 2 + evaluate to 3");
    Console.WriteLine("Example: 2 2 * 5 + evaluate to 9");

    while (true)
    {
      Console.Write("> ");
      string input = Console.ReadLine();
      string output = parser.Parse(input);
      Console.WriteLine(output);
    }
  }
}
