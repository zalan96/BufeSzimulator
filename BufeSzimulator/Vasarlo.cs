using System;
using System.Collections.Generic;
using System.Text;

namespace BufeSzimulator
{
    public class Vasarlo
    {
        public int Penz { get; set; }
        public int ElkoltottPenz { get; set; }
        public List<Termek> Vasarlasok { get; set; }

        public Vasarlo(int penz)
        {
            Penz = penz;
            ElkoltottPenz = 0;
            Vasarlasok = new List<Termek>();
        }

        public bool TudVasarolni(Termek termek)
        {
            return Penz >= termek.Ar;
        }

        public void Vasarol(Termek termek)
        {
            if (TudVasarolni(termek))
            {
                Penz -= termek.Ar;
                ElkoltottPenz += termek.Ar;
                Vasarlasok.Add(termek);
            }
            else
            {
                throw new InvalidOperationException("Nincs elég pénz a vásárláshoz.");
            }
        }
    }
}
