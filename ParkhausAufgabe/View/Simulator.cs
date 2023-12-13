using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkhausAufgabe
{
    public partial class Simulator : Form
    {
        private int _anzahletagen;
        private int _parkplaetzeproetage;
        

        public int AnzahlEtagen
        {
            get { return _anzahletagen; }
            set { _anzahletagen = value; }
        }
        public int Parkplaetzeproetage
        {
            get { return _parkplaetzeproetage; }
            set { _parkplaetzeproetage = value; }
        }


        public Simulator()
        {
            InitializeComponent();
        }

        private void Simulator_Load(object sender, EventArgs e)
        {
            int _totalparkplaetze = _anzahletagen * _parkplaetzeproetage;
            label1.Text = "Anzahl Etagen: " + AnzahlEtagen.ToString();
            label2.Text = "Parkplaetze pro Etage: " + Parkplaetzeproetage.ToString();
        }
    }
}
