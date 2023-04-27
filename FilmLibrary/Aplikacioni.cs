using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Aplikacioni
    {
        //singleton pattern 
        private static Libraria libraria;
        public static Libraria KrijoLibrarine()
        {
            // kjo kujdeset qe vetem heren e pare na e krijon
            // heren tjeter na jep kopjen e objektit
            if(libraria == null)
                libraria = new Libraria();

            return libraria;
        }

        //cache 
        private static List<Aktori> listaMeAktore;
        public static List<Aktori> ListaMeAktore()
        {
            if (listaMeAktore == null)
            {
                listaMeAktore = new List<Aktori>();
                listaMeAktore.Add(new Aktori() { Emri = "Brad", Mbiemri = "Pitt" });
                listaMeAktore.Add(new Aktori() { Emri = "Demi", Mbiemri = "Moore" });
                listaMeAktore.Add(new Aktori() { Emri = "Kate", Mbiemri = "Moss" });
            }


            return listaMeAktore;
        }
    }
}
