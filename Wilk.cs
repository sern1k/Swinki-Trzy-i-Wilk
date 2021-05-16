using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Wilk
    {
        private int poziom = 1;
        static public int Podmuch { get; private set; }

        public int Poziom
        {
            get { return poziom; }
            set 
            {
                if (value == 1)
                    Podmuch = 350;
                else if (value == 2)
                    Podmuch = 450;
                else
                    Podmuch = 600;
            }
        }

    }
}
