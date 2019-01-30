using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{

  public class Player
  {
    int handMaxSize = 5;
    public List<Card> Hand = new List<Card>();

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