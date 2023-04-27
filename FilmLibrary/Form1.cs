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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UKlikuaForma(object sender, EventArgs e)
        {
            // singleton pattern 
            Libraria lib = new Libraria();
            dataGridView2.DataSource = lib.ListaMeFilma();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new System.EventHandler(UKlikuaForma);



            Aktori a2 = new Aktori();
            Aktori a3 = new Aktori();
            Aktori a4 = new Aktori();

            Aktori a1 = new Aktori
            {
                Id = 1,
                Emri = "Brad",
                Mbiemri = "Pitt"
            };

            a2.Id = 1;
            a2.Emri = "Keannu";
            a2.Mbiemri = "Reeves";

            a3.Id = 1;
            a3.Emri = "Chuck";
            a3.Mbiemri = "Norris";

            a4.Id = 1;
            a4.Emri = "Tom";
            a4.Mbiemri = "Cruise";

            var a5 = new Aktori() 
            {
                Id = 1,
                Emri = "John",
                Mbiemri = "Wayne"
            };



            //
            List<Filmi> lista = new List<Filmi>();
            Filmi f1 = new Filmi();
            Filmi f2 = new Filmi();

            f1.Id = 1;
            f1.Titulli = "Django Unchained";
            f1.Aktoret = new List<Aktori>();
            f1.Aktoret.Add(a1);
            f1.Aktoret.Add(a2);
            f1.Aktoret.Add(a5);
            lista.Add(f1);


            lista.Add(f2);
            f2.Id = 2;
            f2.Titulli = "Green Book";
            f2.Aktoret = new List<Aktori>();
            f2.Aktoret.Add(a2);
            f2.Aktoret.Add(a3);
            f2.Aktoret.Add(a4);


            //ruaje ne json
            Libraria lib = new Libraria(lista);
            lib.RuajFilmatNeJson();


        }

        private void btnNewFilm_Click(object sender, EventArgs e)
        {
            //
            NewMovie forma = new NewMovie();
            forma.Edit = false;
            DialogResult result = forma.ShowDialog();

            Libraria lib = Aplikacioni.KrijoLibrarine();
            dataGridView2.DataSource = lib.ListaMeFilma();


            //if(result == DialogResult.OK)   
            //    // aha e ka ruajtur
            //    else

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            if (MessageBox.Show("a je i sigurt", "ok", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;

            Libraria lib = Aplikacioni.KrijoLibrarine();
            lib.RuajFilmatNeJson();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            List<Filmi> lista = (List<Filmi>)dataGridView2.DataSource;
            int rreshti = e.RowIndex;
            Filmi filmi = lista[rreshti];
            NewMovie newMovie = new NewMovie();
            newMovie.FilmiISelektuar = filmi;
            newMovie.Edit = true;
            newMovie.ShowDialog();
        }
    }
}
