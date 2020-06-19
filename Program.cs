using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {    
            int númeroum, númerodois;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira dois números inteiros.");
            Console.WriteLine("Primeiro número: ");
            bool númeroumbool = Int32.TryParse(Console.ReadLine(), out númeroum);
            Console.WriteLine("Segundo número: ");
            bool númerodoisbool = Int32.TryParse(Console.ReadLine(), out númerodois);

            if (!númeroumbool || !númerodoisbool || númeroum > númerodois)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                while (númeroum <= númerodois)
                {
                Console.Write($"{númeroum} ");
                númeroum = númeroum + 1;
                }
                Console.ResetColor();
            }
            
            

        }
    }
}
