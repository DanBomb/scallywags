using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{

  public class Player
  {
    int handMaxSize = 5;
    public List<Card> Hand = new List<Card>();


    public Ship player = new Ship(1, "The Player's Ship");


    // These are the player's ship stats
    public int shipLevel;
    public int shipDamage = 10 + 5 * shipLevel;
    public int shipSpeed = 10 + 10 * shipLevel; 
    public int shipHealth = 15 + shipLevel * 5;
   

    // Hard-coded deck of size 10, maybe make that a config variable?
    private Deck deck = new Deck(5);

    public void DrawCard()
    {
      Card c = deck.DrawCard();
      //Card d = deck.DrawCard();
      //Card e = deck.DrawCard();
      if(CanDraw()){
        if (c != null /* && d != null && e != null*/)
        {
          Hand.Add(c);
          Console.WriteLine($"Hand Size: {Hand.Count}; Card Drawn: {c.Title()}; Bonus: {c.Effect()}; System Type: {c.Type()}");
          System.Threading.Thread.Sleep(1000);
          /* if (CanDraw())
          {
            Hand.Add(d);
            Console.WriteLine($"Hand Size: {Hand.Count}; Card Drawn: {d.Title()}; Bonus: {d.Effect()}; System Type: {d.Type()}");
            System.Threading.Thread.Sleep(1000);
          }
          if (CanDraw())
          {
            Hand.Add(e);
            Console.WriteLine($"Hand Size: {Hand.Count}; Card Drawn: {e.Title()}; Bonus: {e.Effect()}; System Type: {e.Type()}");
            System.Threading.Thread.Sleep(1000);
          }*/  
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

    public void ShowHand()
    {
      for (int i = 0; i < Hand.Count; i++)
      {
        Console.WriteLine($"Card: {Hand[i].Title()}; Bonus: {Hand[i].Effect()}; System Type: {Hand[i].Type()}");
        Console.WriteLine();
        System.Threading.Thread.Sleep(800);
      }
    }
  }
}