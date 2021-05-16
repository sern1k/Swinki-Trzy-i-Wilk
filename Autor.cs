using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    static class Autor
    {
        static public void Omnie()
        {
            Logo.Nazwa();
            Console.WriteLine("\n O autorze\n");
            Thread.Sleep(500);
            Console.WriteLine("Mam na imię Pola.");
            Thread.Sleep(750);
            Console.WriteLine("Jestem na I roku Elektroniki na AGH w Krakowie.");
            Thread.Sleep(1000);
            Console.WriteLine("Ta gra jest projektem zaliczeniowym na zajęcia Podstawy Informatyki.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\nWciśnij B, żeby wrócić do Menu.");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.B)
                Menu.Wybierz();
            else
            {
                Console.Clear();
                Autor.Omnie(); 
            }
        }
    }
}
