using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    static class Logo
    {
        static public void Nazwa()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  ____          _       _    _     _                  ");
            Console.WriteLine(@" / ___|_      _(_)_ __ | | _(_)   | |_ _ __ _____   _ ");
            Console.WriteLine(@" \___ \ \ /\ / / | '_ \| |/ / |   | __| '__|_  / | | |");
            Console.WriteLine(@"  ___) \ V  V /| | | | |   <| |   | |_| |   / /| |_| |");
            Console.WriteLine(@" |____/ \_/\_/ |_|_| |_|_|\_\_|    \__|_|  /___|\__, |");
            Console.WriteLine(@"                                                |___/ ");
            Console.ResetColor();
        }
    }
}
