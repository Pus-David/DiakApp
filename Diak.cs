using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        private int pontszam { get; set; }
        public int Pontszam
        {
            get { return pontszam; }
            set
            {
                if (value <0)
                {
                    pontszam = 0;
                }
                else if (value >100)
                {
                    pontszam = 100;
                }
                else
                {
                    pontszam = value;
                }
            }
        }
        public Diak (string nev, string osztaly, int pontszam)
        {
            Nev = nev;
            Osztaly = osztaly;
            Pontszam = pontszam;
        }
        public override string ToString()
        {
            return $"ˇ\"{Nev} ({Osztaly}) - {Pontszam}"
        }

    }
}
