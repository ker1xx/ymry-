using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace fuuuuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 1;
            int sum = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
            while (key.Key != ConsoleKey.O)
            {
                order podklass = new order();
                podklass.Hueta(sum);
/*                if (key.Key == ConsoleKey.Enter)
                {
                    
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                }
                Console.SetCursorPosition(0, pos);
                if (key.Key != ConsoleKey.Enter)
                    Console.WriteLine("->");
                key = Console.ReadKey();*/
            }
        }
    }
}