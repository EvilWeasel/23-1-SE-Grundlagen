Console.WriteLine("Schleifen-Demo");
int iterCount = 0;

while (iterCount > 10)
{
  Console.WriteLine("WHILE");
  iterCount = iterCount + 1;
  //iterCount--;
  // --iterCount; !! ACHTUNG: Nicht das gleiche! Mit vorsicht genießen.
}

iterCount = 10;
do
{
  Console.WriteLine("DO-WHILE");
  iterCount--;
  //iterCount = iterCount - 1;
} while (iterCount > 0);


Console.WriteLine("FOR-LOOP");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("FOR");
}


List<int> ints = new List<int>() { 1, 2, 3, 42, 100, 200, 23 };

foreach (var x in ints)
{
  Console.WriteLine(x);
}