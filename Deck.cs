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
    public List<string> effects;
    public List<string> systemTypes;
    private static Random rnd = new Random();

    public Deck(int maxSize = 5)
    {
      size = maxSize;
      currentSize = maxSize;
      names = new List<string> { "Eyepatch", "Peg Leg", "Rifled Cannons", "Jolly Roger", "Hired Mercenary", 
      "Cowardly Running?", "Good Eyes", "Holy Hand Grenade", "Boat Insurance", "Attacked by Seagulls"};
      descriptions = new List<string> { "Increase Speed", "Better Targeting", "Increase Damage", "Increase Damage", "Increase Damage", 
      "Free Pass from Combat", "Double Loot for Single Turn", "Increase Damage", "Upgrade Entire Ship", "Decrease Health"};
      effects = new List<string> {"Speed +1", "Targeting +1", "Damage +1", "Damage +5", "Damage +3", 
      "Free Pass", "Double Loot", "Combat +3", "Ship Upgrade", "Health -3"};
      systemTypes = new List<string> {"Crew", "Crew", "Deck", "Rigging", "Crew", "Combat", "Crew", "Combat", "Ship"};
    }

    public Card DrawCard(int cardsToDraw = 1)
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