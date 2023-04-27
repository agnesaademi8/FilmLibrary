using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class NewMovie : Form
    {
        public bool Edit { get; set; }

        public Filmi FilmiISelektuar
        {
            get
            {
                Filmi filmi = new Filmi();
                filmi.Id = NewId();


                filmi.Titulli = txtTitulli.Text;
                filmi.Pershkrimi = rtbPershkrimi.Text;

                // filmi.Zhanri = cboAktoret.SelectedIndex;


                filmi.Aktoret = new List<Aktori>();
                foreach (var item in listAktoret.Items)
                {
                    filmi.Aktoret.Add((Aktori)item);
                }

                return filmi;
            }
            set
            {
                Filmi f = value;
                txtTitulli.Text = f.Titulli;
                rtbPershkrimi.Text = f.Pershkrimi;

                foreach (var aktor in f.Aktoret)
                {
                    listAktoret.Items.Add(aktor);
                }
            }
        
        }

        public NewMovie()
        {
            InitializeComponent();
        }

        int NewId()
        {
            Libraria libraria = Aplikacioni.KrijoLibrarine();
            int max = 0;
            foreach (var film in libraria.ListaMeFilma())
            {
                if (max < film.Id)
                    max = film.Id;
            }

            return max + 1;
        }
        private void btnRuaje_Click(object sender, EventArgs e)
        {
            // objekt filmi
            // titulli etj
            if (Edit == true)
                NdryshoFilm(FilmiISelektuar);
            else
                FilmIRi();

        }


        void FilmIRi()
        {
            //
            Libraria lib = Aplikacioni.KrijoLibrarine();
            lib.RuajeFilmin(FilmiISelektuar);

        }

        void NdryshoFilm(Filmi filmi)
        {
            //fshije filmin ekzistues
            // ruaje te selektuarin si te ri

        }


        private void NewMovie_Load(object sender, EventArgs e)
        {
            /*
            object obj = 1;
            object o2 = "test";
            object o3 = new Aktori();

            int njeshi = (int)obj;
            string o2s = (string)o2;
            var a = (Aktori)o3;
            Type tipi = o3.GetType();

            var listProp = tipi.GetProperties();
            */

            //pra ky eshte funksioni qe ekezekutohet kur forma behet LOAD, kur hapet
            var listaAktoret = Aplikacioni.ListaMeAktore();
            for (int i = 0; i < listaAktoret.Count; i++)
            {
                cboAktoret.Items.Add(listaAktoret[i]);
            }

            //cboAktoret.Items.Add("test1");
            //cboAktoret.Items.Add("test3");
            //cboAktoret.Items.Add("test2");
            //cboAktoret.Items.Add("test4");

        }

        private void cboAktoret_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            int index = cboAktoret.SelectedIndex;
            Aktori aktori = (Aktori)cboAktoret.Items[index];
            if (listAktoret.Items.Contains(aktori) == false)
                listAktoret.Items.Add(aktori);
        }
    }
}
