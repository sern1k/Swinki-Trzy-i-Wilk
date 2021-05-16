using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    static class Rozgrywka
    {
        static public bool Granie()
        {
            Domek domek1 = new Domek() { };

            domek1.Buduj();

            Console.Clear();
            Console.WriteLine("O nie! Idzie straszny wilk! Czy uda nam się przetrwać?\n");

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }


            if (domek1.Wytrzymałość > Wilk.Podmuch)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
