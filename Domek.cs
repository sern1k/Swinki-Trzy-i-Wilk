using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    class Domek
    {
        static private int ruchy;
        private int wytrzymałość = 0;
        static private int wybierz;

        public int Wytrzymałość 
        { 
            get
            {
                return wytrzymałość;
            }
            set
            {
                wytrzymałość = value;
            }
        }

        static public int Ruchy
        {
            get
            {
                return ruchy;
            }
            set
            {
                if (value >= 0)
                    ruchy = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zły ruch");
                    Console.ResetColor();
                    Thread.Sleep(500);
                }
            }
        }

        static public int Wybierz
        {
            get
            {
                return wybierz;
            }
            set
            {
                if (value >= 1 && value <= 5)
                        wybierz = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawna opcja");
                    Console.ResetColor();
                    Thread.Sleep(500);
                }
            }
        }

        public void Buduj()
        {
            Ruchy = Gra.PunktyRuchu;
            while (Ruchy > 0)
            {
                Console.Clear();
                Console.WriteLine("Wybierz z czego chcesz budować swój domek.\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Masz do wykorzystania " + Ruchy + " punktów ruchu.");
                Console.WriteLine("Obecna wytrzymałość domku: " + Wytrzymałość + ".\n");
                Console.ResetColor();
                Console.WriteLine("1. Patyki - 5 wytrzymałości - 1 punkt ruchu");
                Console.WriteLine("2. Palety - 10 wytrzymałości - 3 punkty ruchu");
                Console.WriteLine("3. Deski - 50 wytrzymałości - 20 punktów ruchu");
                Console.WriteLine("4. Bruk - 75 wytrzymałości - 30 punktów ruchu");
                Console.WriteLine("5. Kamień - 100 wytrzymałości - 45 punktów ruchu\n");

                try
                {
                    string y = Console.ReadLine();
                    Wybierz = int.Parse(y);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zły wybór");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    continue;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zły wybór");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    continue;
                }

                int pomoc = Ruchy;

                switch (Wybierz)
                {
                    case 1:
                        Ruchy -= 1;
                        if (Ruchy != pomoc)
                            Wytrzymałość += 5;
                        break;
                    case 2:
                        Ruchy -= 3;
                        if (Ruchy != pomoc)
                            Wytrzymałość += 10;
                        break;
                    case 3:
                        Ruchy -= 20;
                        if (Ruchy != pomoc)
                            Wytrzymałość += 50;
                        break;
                    case 4:
                        Ruchy -= 30;
                        if (Ruchy != pomoc)
                            Wytrzymałość += 75;
                        break;
                    case 5:
                        Ruchy -= 45;
                        if (Ruchy != pomoc)
                            Wytrzymałość += 100;
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Brawo! Zbudowałeś domek!");
            Thread.Sleep(2000);
        }
    }
}
