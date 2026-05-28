using System;
using System.Collections.Generic;
using System.Text;

namespace BufeSzimulator
{
    public class Etel : Termek
    {
        public int Kaloria   { get; set; }

        public Etel(string nev, int ar, int kaloria) : base(nev, ar)
        {
            Kaloria = kaloria;
        }

        public override string Kategoria()
        {
            return "Étel";
        }

        public override string Reszletek()
        {
            return $"Név: {Nev}\nÁr: {Ar} Ft\nKalória: {Kaloria} kcal\n{Kategoria()}";
        }
    }
}
