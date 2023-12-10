using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_akos.Models;

namespace zh3_akos
{
    public partial class VasarlasokUc : UserControl
    {
        Zh3Context zh3Context = new Zh3Context();
        public VasarlasokUc()
        {
            InitializeComponent();
            SzallitoListazas();
        }

        private void SzallitoListazas()
        {
            var szallito = from x in zh3Context.Szállítóks
                           select x;

            listBoxSzallitok.DataSource = szallito.ToList();
            listBoxSzallitok.DisplayMember = "Név";
        }

        

        public void buttonOk_Click(object sender, EventArgs e)
        {

            Szállítók szallitok = new Szállítók();
            //szallitok.SzállítóId = //a max id plusz egy kell
            szallitok.Név = textBoxNev.Text;
            szallitok.Ország = textBoxOrszag.Text;
            szallitok.TevékenységTerület = textBoxTevekenyseg.Text;
            zh3Context.Szállítóks.Add(szallitok);



            //Rendelések rendeles = new Rendelések();
            //rendeles.Szállító = szallitok;
            //zh3Context.Rendeléseks.Add(rendeles);
            zh3Context.SaveChanges();

            SzallitoListazas();
        }

        private bool IsSzállítóInRendelések(int szállítóId)
        {
            //Ellenőrizd, hogy az adott szállító ID szerepel-e a rendeléseidben
            var isInRendelések = zh3Context.Rendeléseks.Any(r => r.SzállítóId == szállítóId);

            return isInRendelések;
        }

        private void buttonMinusz_Click(object sender, EventArgs e)
        {
            var szallitoId = ((Szállítók)listBoxSzallitok.SelectedItem).SzállítóId;
            var torlendo = (from x in zh3Context.Szállítóks
                            where x.SzállítóId == szallitoId
                            select x).FirstOrDefault();

            var torlendorendeles = (from x in zh3Context.Rendeléseks
                                    where x.SzállítóId == szallitoId
                                    select x).FirstOrDefault();
            zh3Context.Szállítóks.Remove(torlendo);



            if (IsSzállítóInRendelések(szallitoId) == true)

            {
                zh3Context.Rendeléseks.Remove(torlendorendeles);
            }


            zh3Context.SaveChanges();

            SzallitoListazas();
        }


        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrszag_TextChanged(object sender, EventArgs e)
        {
        }

        private void VasarlasokUc_Load(object sender, EventArgs e)
        {
        }

        private void textBoxTevekenyseg_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
