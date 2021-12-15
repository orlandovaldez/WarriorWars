using System;
using System.Threading;
using WarriorWars.Enums;

namespace WarriorWars
{
   class Program
   {
      static Random rng = new Random();

      static void Main(string[] args)
      {
         Warrior JusticeLeague = new Warrior("Superman", Faction.JusticeLeage);
         Warrior JusticeLeague2 = new Warrior("Wonder Woman", Faction.JusticeLeage);
         Warrior JusticeLeague3 = new Warrior("The Flash", Faction.JusticeLeage);
         Warrior JusticeLeague4 = new Warrior("Martian ManHunter", Faction.JusticeLeage);
         Warrior JusticeLeague5 = new Warrior("Batman", Faction.JusticeLeage);

         Warrior LegionOfDoom = new Warrior("Lex Luthor", Faction.LegionOfDoom);
         Warrior LegionOfDoom2 = new Warrior("Bane", Faction.LegionOfDoom);
         Warrior LegionOfDoom3 = new Warrior("Braniac", Faction.LegionOfDoom);
         Warrior LegionOfDoom4 = new Warrior("Biazarro", Faction.LegionOfDoom);
         Warrior LegionOfDoom5 = new Warrior("Joker", Faction.LegionOfDoom);



         while (JusticeLeague.IsAlive && LegionOfDoom.IsAlive)
         {
            if (rng.Next(0, 10) < 5)
            {
               JusticeLeague.Attack(LegionOfDoom);
               JusticeLeague2.Attack(LegionOfDoom2);
               JusticeLeague3.Attack(LegionOfDoom3);
               JusticeLeague4.Attack(LegionOfDoom4);
               JusticeLeague5.Attack(LegionOfDoom5);
            }
            else
            {
               LegionOfDoom.Attack(JusticeLeague);
               LegionOfDoom2.Attack(JusticeLeague2);
               LegionOfDoom3.Attack(JusticeLeague3);
               LegionOfDoom4.Attack(JusticeLeague4);
               LegionOfDoom5.Attack(JusticeLeague5);
            }

            Thread.Sleep(175);
         }
      }
   }
}
