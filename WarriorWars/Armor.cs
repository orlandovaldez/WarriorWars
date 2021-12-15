using WarriorWars.Enums;

namespace WarriorWars
{
    class Armor
   {

      private const int JUSTICE_LEAGUE_ARMOR = 5;
      private const int LEGION_OF_DOOM_ARMOR = 7;

      private int armorPoints;

      public int ArmorPoints
      {
         get
         {
            return armorPoints;
         }
      }

      public Armor(Faction faction)
      {
         if (faction == Faction.JusticeLeage)
         {
            armorPoints = JUSTICE_LEAGUE_ARMOR;
         }
         else if (faction == Faction.LegionOfDoom)  
         {
            armorPoints = LEGION_OF_DOOM_ARMOR;
         }
      }

   }
}