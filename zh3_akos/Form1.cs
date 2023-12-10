using zh3_akos.Models;

namespace zh3_akos
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kil�p�s meger�s�t�se
            DialogResult result = MessageBox.Show("J�L MEGGONDOLTAD EZT A L�P�ST �CSIP�K??", "Kil�p�s", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Kil�p�s
                e.Cancel = true;
            }
        }

        private void RendelesekBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SzallitokUc rendelesekUc = new SzallitokUc();
            panel1.Controls.Add(rendelesekUc);
            rendelesekUc.Dock = DockStyle.Fill;
        }

        private void TermekekBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ExcelUc termekekUc = new ExcelUc();
            panel1.Controls.Add(termekekUc);
            termekekUc.Dock = DockStyle.Fill;
        }

        private void VasarlasokBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            VasarlasokUc vasarlasokUc = new VasarlasokUc();
            panel1.Controls.Add(vasarlasokUc);
            vasarlasokUc.Dock = DockStyle.Fill;
        }

        private void OkossagokBtn_Click(object sender, EventArgs e)
        {
            Okossagok okossagok = new Okossagok();
            okossagok.ShowDialog();
        }

        private void DataGridViewBtn_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.ShowDialog();
        }
    }


}