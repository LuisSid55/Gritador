using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            String Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite seu texto: ");
            Console.ResetColor();
            Texto = Console.ReadLine();
            Texto = Texto.ToUpper();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Esse é o resultado: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Texto);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
