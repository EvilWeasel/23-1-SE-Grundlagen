void printHello()
{
  Console.WriteLine("Hello");
}

string getHello()
{
  return "Hello";
}

printHello();

var hello = getHello();

hello = hello + " World!";

Console.WriteLine(hello);