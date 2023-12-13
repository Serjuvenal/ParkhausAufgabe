using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausAufgabe
{
    internal class Fahrzeug
    {
		private string _kennzeichnen;
        private string _fahrzeugArt;
		private bool _imParkhaus;
        private Parkplatz _position;

        public string Kennzeichnen
		{
			get { return _kennzeichnen; }
			set { _kennzeichnen = value; }
		}
		public string FahrzeugArt
		{
			get { return _fahrzeugArt; }
			set { _fahrzeugArt = value; }
		}
        public bool ImParkhaus
        {
            get { return _imParkhaus; }
            set { _imParkhaus = value; }
        }
        public Parkplatz Position
        {
            get { return _position; }
            set { _position = value; }
        }

    }
}
