using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
             string frase;
             string tecla="";

            do
              {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine(@"  __\|/__     +-------------+");
               Console.WriteLine(@"  C 6 6(      |  CEBOLINHA  |");
               Console.WriteLine(@"  (  ú  )     +-------------+");
               Console.WriteLine(@"   ''''' ");
               Console.ResetColor();
               Console.WriteLine("Voce diz?");
               frase = Console.ReadLine()
               
               .Replace("R", "L")
               .Replace("r", "l");
               
               Console.WriteLine("\nCeboliha repete:");
               Console.WriteLine(frase);
               Console.Beep();

               Console.WriteLine("\n Sair? (S)");
               tecla = Console.ReadLine().ToUpper();
              }
            while(tecla != "S");
         Console.Clear();    
        }
    }
}
