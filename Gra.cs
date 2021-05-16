using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    static class Gra
    {
        static private int puntyRuchu;
        
        static public int PunktyRuchu
        {
            get 
            { 
                return puntyRuchu; 
            }
            set
            {
                puntyRuchu = value;
            }
        }

        static public void NowaGra()
        {
            Console.Write("Świnki uciekły przed polującym na nie ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("wilkiem");
            Console.ResetColor();
            Console.WriteLine("!");
            Console.WriteLine("Znalazły sobie spokojną okolicę, pomóż im zbudować nowy domek.");
            Console.WriteLine("Tylko pamiętaj, wilk może je znaleźć!");
            Thread.Sleep(5000);

            Console.Clear();
            Logo.Nazwa();
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Podaj imiona 3 świnek (po każdym imieniu wciśnij enter)");
            Świnki świnka1 = new Świnki()
            {
                Imie = Console.ReadLine()
            };
            Świnki świnka2 = new Świnki()
            {
                Imie = Console.ReadLine()
            };
            Świnki świnka3 = new Świnki()
            {
                Imie = Console.ReadLine()
            };

            Wilk wilk1 = new Wilk()
            {
                Poziom = 1
            };

            PunktyRuchu = 150;

            while (wilk1.Poziom > 0)
            {
                if (Rozgrywka.Granie() == true)
                {
                    Console.Clear();
                    Console.WriteLine("Brawo! Przetrwałeś atak wilka!");
                    Console.WriteLine("Ale nie ciesz się za bardzo, on może wrócić...");
                    Thread.Sleep(2000);

                    wilk1.Poziom++;
                    PunktyRuchu += 50;

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\nWciśnij B, żeby wrócić do Menu");
                    Console.WriteLine("Wciśnij P, żeby przejść na kolejny poziom");
                    Console.ResetColor();

                    if (Console.ReadKey().Key == ConsoleKey.B)
                        Menu.Wybierz();
                    else if (Console.ReadKey().Key == ConsoleKey.P)
                    {
                        Console.Clear();
                        Logo.Nazwa();
                        Console.WriteLine("\nNastępny poziom");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Zbudowałeś zbyt niestabilny domek!");
                    Console.WriteLine("Świnki " + świnka1.Imie + ", " + świnka2.Imie + " i " + świnka3.Imie +" zostają zjedzone przez wilka!");
                    Thread.Sleep(2000);

                    wilk1.Poziom = 0;

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\nWciśnij B, żeby wrócić do Menu lub dowolny przycisk, żeby spróbować ponownie.");
                    Console.ResetColor();

                    if (Console.ReadKey().Key == ConsoleKey.B)
                        Menu.Wybierz();
                }
            }

        }
    }
}
