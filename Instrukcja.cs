using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    static class Instrukcja
    {
        static public void JakGrac()
        {
            Logo.Nazwa();
            Console.WriteLine("\n Instrukcja\n");
            Console.WriteLine("Grasz używając numerków przy odpowiednich polach.");
            Console.WriteLine("Gry nie można zapisać ręcznie, gdy już wyjdziesz z rozgrywki cały Twój postęp przepadnie.");
            Console.WriteLine("Powodzenia!\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\nWciśnij B, żeby wrócić do Menu.");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.B)
                Menu.Wybierz();
            else
            {
                Console.Clear();
                Instrukcja.JakGrac();
            }
        }
    }
}
