using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausAufgabe
{
    internal class Parkplatz
    {
		private int _bezeichnung;
		public int Bezeichnung
		{
			get { return _bezeichnung; }
			set { _bezeichnung = value; }
		}

        public Parkplatz(int t_bezeichnung) 
        {
            Bezeichnung = t_bezeichnung;
        }
    }
}
