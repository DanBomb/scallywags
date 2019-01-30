using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{
  public class Deck
  {
    public int size;
    public int currentSize;
    public List<string> names;
    public List<string> descriptions;
    public List<int> effects;
    public List<string> systemTypes;
    private static Random rnd = new Random();

    public Deck(int maxSize = 10)
    {
      size = maxSize;
      currentSize = maxSize;
      names = new List<string> { "Eyepatch", "Peg Leg", "Rifled Cannons", "Jolly Roger", "Hired Mercenary"};
      descriptions = new List<string> { "Speed +1", "Targeting +1", "Ship Power +1", "Ship Power +5", "One Time Use Bonus +3"};
      effects = new List<int> {1, 1, 1, 5, 3};
      systemTypes = new List<string> {"Crew", "Crew", "Deck", "Rigging", "Crew"};
    }

    public Card DrawCard(int cardsToDraw = 1 )
    {
      if (currentSize > 0)
      {
        // Set a random number and use it for both lists
        int r = (rnd.Next(4)+1);
        currentSize--;
        return new Card(names[r], descriptions[r], effects[r], systemTypes[r]);
      } else {
        return null;
      }
    }
  }
}