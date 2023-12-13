using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausAufgabe
{
    internal class Etage
    {
        private string _bezeichnung;
        public string Bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

        public Etage(string t_bezeichnung)
        {
            Bezeichnung = t_bezeichnung;
        }
    }
}
