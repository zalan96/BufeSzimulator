using System;
using System.Collections.Generic;
using System.Text;

namespace BufeSzimulator
{
    public class Ital : Termek
    {
        public int MennyisegMl { get; set; }

        public Ital(string nev, int ar, int mennyisegMl) : base(nev, ar)
        {
            MennyisegMl = mennyisegMl;
        }

        public override string Kategoria()
        {
            return "Ital";
        }

        public override string Reszletek()
        {
            return base.Reszletek() + $"\nMennyiség: {MennyisegMl} ml";
        }

        public override string ToString()
        {
            return $"{Nev} - {Ar} Ft - {MennyisegMl} ml";
        }
    }
}
