using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{

  public class Ship
  {
    int shipLevel;
    int combatDamage;
    int health;
    string description;

    public Ship(int ShipLevel, string Description)
    {
        shipLevel = ShipLevel;
        combatDamage = shipLevel * 12;
        health = shipLevel * 15;
        description = Description;
    }

    public string Description()
    {
      return description;
    }

    public int ShipLevel()
    {
      return shipLevel;
    }
  }
}