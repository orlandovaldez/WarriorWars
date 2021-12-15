using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enums;

namespace WarriorWars.Equipment
{
   class Weapon
   {

      private const int JUSTICE_LEAGUE_DAMAGE = 8;
      private const int LEGION_OF_DOOM_DAMAGE = 6;

      private int damage;

      public int Damage
      {
         get
         {
            return damage;
         }
      }

      public Weapon(Faction faction)
      {
         switch (faction)
         {
            case Faction.JusticeLeage:
               damage = JUSTICE_LEAGUE_DAMAGE;

               break;
            case Faction.LegionOfDoom:
               damage = LEGION_OF_DOOM_DAMAGE;

               break;
            default:
               break;
         }
      }

   }
}
