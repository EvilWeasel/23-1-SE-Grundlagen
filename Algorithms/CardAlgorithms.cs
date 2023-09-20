using System;

namespace Algorithms
{
  public static class CardAlgorithms
  {
    public static int FindCardLocation(int[] cards, int query)
    {
      // initialisiere variable index mit Wert 0
      int index = 0;
      // Schleife bis index gleich länge der cards liste:
      while (index < cards.Length)
      {
        //     Wenn zahl von cards an index gleich query:
        if (cards[index] == query)
        {
          //         Wahr: gebe index zurück
          return index; // Funktion endet hier, falls query gefunden!
        }
        //     Inkrement index um 1
        index++;
      }
      return -1;
    }
  }
}