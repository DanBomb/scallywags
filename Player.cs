using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{

  public class Player
  {
    int handMaxSize = 5;
    public List<Card> Hand = new List<Card>();

    // These are the player's ship stats
    public int shipLevel;
    public int shipDamage = 10 + 5 * shipLevel;
    public int shipSpeed = 10 + 10 * shipLevel; 
    public int shipHealth = 15 + shipLevel * 5;
   
    // Hard-coded deck of size 10, maybe make that a config variable?
    private Deck deck = new Deck(10);

    public void DrawCard()
    {
      Card c = deck.DrawCard();
      if(CanDraw()){
        if (c != null)
        {
          Hand.Add(c);
          Console.WriteLine($"Hand Size: {Hand.Count}; Card Drawn: {c.Title()}");
        }
        else
        {
          Console.WriteLine("Couldn't draw a card!");
        }
      } else {
        Console.WriteLine("Hand is full!");
      }
    }

    public bool CanDraw(){
      return Hand.Count < handMaxSize;
    }

    public void PlayCard(int cardNumber)
    {
      Card card = Hand[cardNumber];
      Hand.RemoveAt(cardNumber);
    }
  }
}