using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausAufgabe
{
    internal class Motorrad : Fahrzeug
    {
        public Motorrad(string t_kennzeichnen, string t_fahrzeugArt, bool t_imParkhaus)
        {
            Kennzeichnen = t_kennzeichnen;
            FahrzeugArt = t_fahrzeugArt;
            ImParkhaus = t_imParkhaus;
        }
    }
}
