using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {    
            bool terminar = false;

            while (!terminar)
            {
                int númeroum, númerodois;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Insira dois números inteiros.");
                Console.Write("Primeiro número: ");
                bool númeroumbool = Int32.TryParse(Console.ReadLine(), out númeroum);
                Console.Write("Segundo número: ");
                bool númerodoisbool = Int32.TryParse(Console.ReadLine(), out númerodois);

                if (!númeroumbool || !númerodoisbool || númeroum > númerodois)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido.");
                    Console.WriteLine("Pressione uma tecla para escolher os valores novamente.");
                    Console.ReadKey();
                }
            
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    while (númeroum <= númerodois)
                    {
                    Console.Write($"{númeroum} ");
                    númeroum = númeroum + 1;
                    }
                    terminar = true;
                }
            }    
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPressione uma tecla para finalizar o programa.");
            Console.ReadKey();
            

        }
    }
}
