using System;
using WarriorWars.Enums;
using WarriorWars.Equipment;

namespace WarriorWars
{
   class Warrior
   {

      private const int JUSTICE_LEAGUE_INITIAL_HEALTH = 20;
      private const int LEGION_OF_DOOM_INITIAL_HEALTH = 20;


      private readonly Faction FACTION;

      private int health;
      private string name;
      private bool isAlive;

      public bool IsAlive
      {
         get
         {
            return isAlive;
         }
      }

      private Weapon weapon;
      private Armor armor;

      public Warrior(string name, Faction faction)
      {
         this.name = name;
         this.FACTION = faction;
         isAlive = true;

         switch (faction)
         {
            case Faction.JusticeLeage:
               weapon = new Weapon(faction);
               armor = new Armor(faction);
               health = JUSTICE_LEAGUE_INITIAL_HEALTH;

               break;
            case Faction.LegionOfDoom:
               weapon = new Weapon(faction);
               armor = new Armor(faction);
               health = LEGION_OF_DOOM_INITIAL_HEALTH;

               break;
            default:
               break;
         }

      }

      public void Attack(Warrior enemy)
      {
         int damage = weapon.Damage / enemy.armor.ArmorPoints;

         enemy.health = (enemy.health - damage);

         AttackResult(enemy, damage);
      }

      private void AttackResult(Warrior enemy, int damage)
      {
         if (enemy.health <= 0)
         {
            enemy.isAlive = false;

            Console.WriteLine();
            Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
            Console.WriteLine();
            Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);

         }
         else
         {
            Console.WriteLine();
            Console.WriteLine($"{name} attacked {enemy.name}. ");
            Console.WriteLine();
            Tools.ColorfulLine($"{damage}", ConsoleColor.Yellow);
            Tools.ColorfulLine($" damage was inflicted to ", ConsoleColor.DarkRed);
            Tools.ColorfulWriteLine($"{enemy.name}", ConsoleColor.White);
            Tools.ColorfulLine($"remaining health of { enemy.name} is ", ConsoleColor.DarkRed); 
            Tools.ColorfulLine($"{enemy.health}", ConsoleColor.Cyan);
            Console.WriteLine();
            Tools.ColorfulWriteLine("______________________________________", ConsoleColor.Gray);
         }
      }
   }
}
   