
Console.WriteLine("Wie viele Zufallszahlen möchtest du?");

var inputAmount = Console.ReadLine();


var randomAmount = int.Parse(inputAmount);

var rng = new Random();

int[] randomNumbers = new int[randomAmount];

for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = rng.Next(0, 69);
}

Console.WriteLine(string.Join(", ", randomNumbers));

//while (true) 
//{
//  if ("test" == "test")
//  {
//    break;
//  }
//
//
//  Console.WriteLine("test");
//}