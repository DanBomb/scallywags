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

    public Ship(int ShipLevel)
    {
        shipLevel = ShipLevel;
        combatDamage = shipLevel * 12;
        health = shipLevel * 15;
    }
  }
}