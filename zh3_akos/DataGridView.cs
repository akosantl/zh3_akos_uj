using System.Data;
using zh3_akos.Models;

namespace zh3_akos
{

    public partial class DataGridView : Form
    {
        Zh3Context zh3Context = new Zh3Context();

        public DataGridView()
        {
            InitializeComponent();
            listBoxSzallitok.DisplayMember = "Név";
            listBoxRendelesek.DisplayMember = "RendelésId";
            SzűrésSzallitok();

        }

        private void SzűrésSzallitok()
        {
            var query = from x in zh3Context.Szállítóks
                        where x.Név.Contains(textBoxSzallitok.Text)
                        select x;

            listBoxSzallitok.DataSource = query.ToList();

        }

        private void SzallitokNev()
        {
            if (listBoxSzallitok.SelectedItem != null)
            {
                var szallitok = ((Szállítók)listBoxSzallitok.SelectedItem).SzállítóId;
                var megjelen = from x in zh3Context.Rendeléseks
                               where x.SzállítóId == szallitok
                               select x;

                listBoxRendelesek.DisplayMember = "RendelésId";
                listBoxRendelesek.DataSource = megjelen.ToList();
            }
        }



        private void NevRendelo()
        {
            if (listBoxRendelesek.SelectedItem != null)
            {
                var query = ((Rendelések)listBoxRendelesek.SelectedItem).TermékId;
                var megjelen = from x in zh3Context.Termékeks
                               where x.TermékId == query
                               select new DataClass
                               {
                                   TermékId = x.TermékId,
                                   Név = x.Név,
                                   Kategória = x.Kategória,
                                   Ár = x.Ár,
                                   Raktáron = x.Raktáron
                               };

                dataGridView1.DataSource = megjelen.ToList();
            }
        }


        private void listBoxSzallitok_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzallitokNev();
        }

        private void listBoxRendelesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            NevRendelo();
        }

        private void textBoxSzallitok_TextChanged(object sender, EventArgs e)
        {
            SzűrésSzallitok();
        }






    }
}

