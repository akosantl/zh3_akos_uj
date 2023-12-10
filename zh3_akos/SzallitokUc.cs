using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_akos.Models;
using static Azure.Core.HttpHeader;

namespace zh3_akos
{
    public partial class SzallitokUc : UserControl
    {
        Zh3Context zh3Context = new Zh3Context();

        public SzallitokUc()
        {
            InitializeComponent();


            Listázás();

        }

        private void Listázás()
        {
            var query = from x in zh3Context.Vevőks
                        where x.Név.Contains(textBoxNev.Text)
                        select x;

            dataGridView1.DataSource = query.ToList();
        }

        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlusz_Click(object sender, EventArgs e)
        {
            Vevők vevok = new Vevők();

            vevok.Név = textBoxNev.Text;
            vevok.Telefonszám = textBoxTelszam.Text;
            vevok.VevőId = zh3Context.Vevőks.Count() + 1;
            zh3Context.Vevőks.Add(vevok);
            zh3Context.SaveChanges();

            Listázás();

        }

        private bool CheckNev(string nev)
        {
            Regex regex = new Regex("^[A-Z]\\w+( [A-Z]\\w+)+$");
            return regex.IsMatch(nev);
        }

        private bool CheckEmpty(string adat)
        {
            return !string.IsNullOrEmpty(adat);
        }

        private void textBoxNev_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckNev(textBoxNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNev, "Töltse ki helyesen a mezőt!");
            }
        }

        private void textBoxNev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNev, "");
        }

        private void textBoxTelszam_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBoxTelszam.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTelszam, "Ne hagyja üresen!");
            }
        }

        private void textBoxTelszam_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTelszam, "");
        }
    }
}
