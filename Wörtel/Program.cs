/*
 * Programmstart:
 * 
 * Definiere solutionWord als das zu erratende Wort fest
 * 
 * Schleife:
 *    Definiere guess und speicher das vom User eingegebene Wort
 *    Schleife für jeden Buchstaben im guess:
 *        Schleife für jeden Buchstaben im solutionWord:
 *            Prüfe Buchstabe aus guess gleich Buchstabe in solutionWord:
 *                Wahr:
 */

var solutionWord = "HOTEL";

string guess;

while (true)
{
  Console.WriteLine("Errate das 5-Stellige Wort");
  guess = Console.ReadLine();
  guess = guess.ToUpper();
  if (guess.Length != 5) continue;


  // Gedankenspiel
  // Rooms
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
  //int i = 0;
  //while (0 < guess.Length)
  //{
  //  var c = guess[i];
  //  // dein code...
  //  i++;
  //}
}