namespace ParkhausAufgabe
{
    public partial class Willkommen : Form
    {


        public Willkommen()
        {
            InitializeComponent();
        }

        private void Willkommen_Load(object sender, EventArgs e)
        {

        }
        private void btn_starten_Click(object sender, EventArgs e)
        {
            int t_anzahletagen;
            int t_parkplaetzeproetage;

            if (tb_anzahletagen.Text == null || tb_parkplaetzeproetage.Text == null)
            {
                MessageBox.Show("Bitte geben Sie alle Parametern ein.", "Fehlende Parametern!", MessageBoxButtons.OK);
            }
            else
            {
                t_anzahletagen = Convert.ToInt32(tb_anzahletagen.Text);
                t_parkplaetzeproetage = Convert.ToInt32(tb_parkplaetzeproetage.Text);
                this.Hide();
                using (Simulator simulator = new Simulator())
                {
                    TextBoxLeeren();
                    simulator.AnzahlEtagen = t_anzahletagen;
                    simulator.Parkplaetzeproetage = t_parkplaetzeproetage;
                    simulator.ShowDialog();
                }
            }
        }
        private void btn_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tb_anzahletagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void tb_parkplaetzeproetage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TextBoxLeeren()
        {
            tb_parkplaetzeproetage.Text = null;
            tb_anzahletagen.Text = null;
        }
    }
}