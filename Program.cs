using System;
using Figgle;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0 ;


            while (numero <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Preparar...");
                Console.ResetColor();
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Apontar...");
                Console.ResetColor();
                Console.Write("\n");
            
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("FOGO!");
                Console.ResetColor();
                Console.WriteLine($"numero = {numero}");
                numero ++ ;
            }
            Console.WriteLine(FiggleFonts.Colossal.Render("Booom"));
            
                  
        }
    }
}
