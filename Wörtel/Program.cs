var projectPath = Directory.GetCurrentDirectory();
var csvPath = Path.Combine(projectPath, @"..\..\..\words\valid_solutions.csv");
var solutionWordList = GetSolutionsFromFile(csvPath);

var solutionWord = PickSolution(solutionWordList);


string guess;
while (true)
{
  guess = GetGuess("Errate das 5-Stellige Wort");
  

  /* Todo:
   - Groß- und Kleinschreibung :Done
   - Farbe zurücksetzen nach Ausgabe :Done
   - Vordergrundfarbe auf Schwarz ändern; Default Background vielleicht weiß? :Done
   - Ausgabe in einer Zeile :Done
   - Wenn einmal vorkommender Buchstabe im guess zweimal vorkommt, darf das zweite Vorkommen nicht Gelb sein
   - Versuche zählen und User Feedback geben ob er das Wort erraten hat oder er alle Versuche verbraten hat
   */
  Console.ForegroundColor = ConsoleColor.Black;
  for (int i = 0; i < guess.Length; i++)
  {
    Console.BackgroundColor = ConsoleColor.White;
    if (solutionWord.Contains(guess[i]))
      Console.BackgroundColor = ConsoleColor.Yellow;
    if (solutionWord[i] == guess[i])
      Console.BackgroundColor = ConsoleColor.Green;
    Console.Write($"{guess[i]}");
  }
  Console.BackgroundColor= ConsoleColor.Black;
  Console.ForegroundColor = ConsoleColor.White;
  Console.WriteLine();
}

List<string> GetSolutionsFromFile(string path)
{
  var solutions = new List<string>();

  using (var reader = new StreamReader(path))
  {
    while (reader.EndOfStream == false)
    {
      var line = reader.ReadLine();
      solutions.Add(line);
    }
  }

  return solutions;
}

string PickSolution(List<string> solutionWordList)
{
  Random rng = new Random();
  var nextSolutionIndex = rng.Next(0, solutionWordList.Count);

  var solutionWord = solutionWordList[nextSolutionIndex];
  solutionWord = solutionWord.ToUpper();
  return solutionWord;
}

string GetGuess(string prompt)
{
  Console.WriteLine(prompt);
  guess = Console.ReadLine();
  guess = guess.ToUpper();
  if (guess.Length != 5) GetGuess(prompt);
  return guess;
}