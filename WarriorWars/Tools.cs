using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars
{
   static class Tools
   {
      public static void ColorfulWriteLine(string text, ConsoleColor color)
      {
         Console.ForegroundColor = color;
         Console.WriteLine(text);
         Console.ResetColor();
      }
      
      public static void ColorfulLine(string text, ConsoleColor color)
      {
         Console.ForegroundColor = color;
         Console.Write(text);
         Console.ResetColor();
      }

   }
}
