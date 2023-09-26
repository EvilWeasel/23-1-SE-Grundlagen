namespace Taschenrechner;

internal class Program
{
  static void Main(string[] args)
  {

  }
}
decimal GetNumber()
{
  decimal num = 0;
  bool checkNumer = false;
  do
  {
    Console.WriteLine("Gebe eine Zahl ein");
    string input = Console.ReadLine();
    checkNumer = decimal.TryParse(input, out num);

    if (checkNumer == false)
    {
      Console.WriteLine("Ungültige Eingabe: Nur Ganzzahlen sind erlaubt");
    }
  } while (checkNumer == false);
  return num;
}

string GetOperation()
{
  string operation;
  bool validOperation;

  do
  {
    Console.WriteLine("Wähle eine Operation ( + - * / ):");
    operation = Console.ReadLine();

    validOperation = operation == "+" || operation == "-" || operation == "*" || operation == "/";

    if (validOperation == false)
    {
      Console.WriteLine("Ungültige Operation, versuche es erneut.");
    }

  } while (validOperation == false);

  return operation;
}

decimal Calculate(decimal num1, decimal num2, string operation)
{
  switch (operation)
  {
    case "+":
      return num1 + num2;
    case "-":
      return num1 - num2;
    case "*":
      return num1 * num2;
    case "/":
      if (num2 == 0)
      {
        Console.WriteLine("Ungültige Operation: Teilen durch null nicht erlaubt!");
        return 0;
      }
      return num1 / num2;
    default:
      Console.WriteLine("Ungültige Operation: Mögliche Werte sind + - * /");
      return 0;
  }
}


Console.WriteLine("Willkommen beim Taschenrechner 3000");
while (true)
{
  // Get User-Input
  var num1 = GetNumber();
  var num2 = GetNumber();
  var operation = GetOperation();

  // Calculate result
  var result = Calculate(num1, num2, operation);

  // Display Output
  Console.WriteLine($"{num1} {operation} {num2} = {result}");
  Console.WriteLine("Drücke beliebige Taste für weitere Berechnungen, oder beende das Programm mit Strg+C");
  Console.ReadKey();
  Console.Clear();
}



// Entweder (Var), Oder (Datentyp eg. string, decimal, float, decimal,...)
//string test1 = "Buxtehude";
//decimal test2 = 69;
//var test3 = "Buxtehude";
//test3 = 69;
//var decimal x = 420; // "Var" ist nicht kombinierbar mit Datentypenangaben

// var res = Calculate(10, 20, "%"); => So könnte die Funktion mit einem falschen Wert aufgerufen werden..
