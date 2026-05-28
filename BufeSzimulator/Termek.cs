using System;
using System.Collections.Generic;
using System.Text;

namespace BufeSzimulator
{
    public class Termek
    {
        public string Nev { get; set; }
        public int Ar { get; set; }  

        public Termek(string nev, int ar)  
        {
            Nev = nev;
            Ar = ar;
        }

        public virtual string Kategoria()
        {
            return "Termék";
        }

        public virtual string Reszletek()
        {
            return $"Név: {Nev}\nÁr: {Ar} Ft\n{Kategoria()}";
        }

        public override string ToString()
        {
            return $"{Nev} - {Ar} Ft";
        }
    }
}
