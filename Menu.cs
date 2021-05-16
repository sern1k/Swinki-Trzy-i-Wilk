using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    static class Menu
    {
        static private int wybor;

        static public int Wybor
        {
            get
            {
                return wybor;
            }
            set 
            {
                if (value >= 1 && value <= 4)
                    wybor = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawna opcja");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Wybierz();
                }
            }
        }

        static public void Wybierz()
        {
            Console.Clear();
            Logo.Nazwa();
            Console.WriteLine("\n1. Nowa gra");
            Console.WriteLine("2. Jak grać?");
            Console.WriteLine("3. O autorze");
            Console.WriteLine("4. Wyjdź z gry\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Wybierz cyfrę odpowiadającą numerowi z menu i zatwierdź Enter");
            Console.ResetColor();

            try
            {
                string x = Console.ReadLine();
                Wybor = int.Parse(x); 
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zły wybór");
                Console.ResetColor();
                Thread.Sleep(2000);
                Menu.Wybierz();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zły wybór");
                Console.ResetColor();
                Thread.Sleep(2000);
                Menu.Wybierz();
            }


            switch (wybor)
            {
                case 1:
                    Console.Clear();
                    Gra.NowaGra();
                    break;
                case 2:
                    Console.Clear();
                    Instrukcja.JakGrac();
                    break;
                case 3:
                    Console.Clear();
                    Autor.Omnie();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
