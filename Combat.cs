using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{

  public class Combat
  {
    public Combat(Ship ship1, Ship ship2)
    {
      
    }

    public void Start(string ship1, string ship2)
    {
      Console.WriteLine("Battle Start!");
      Console.WriteLine();
      Console.WriteLine($"Combatant 1: {ship1}; Combatant 2: {ship2}");

    }
    public int Attack(int CombatDamage)
    {
      return CombatDamage;
    }

    public int TakeDamage(int Damage, int Health)
    {
      return Health - Damage;
    } 
  }
}