using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public enum Zhanri
    {
        Komedi,
        Aksion,
        Triller
    }
    public class Filmi
    {

        public int Id { get; set; }

        public string Titulli { get; set; }

        public string Pershkrimi { get; set; }

        public List<Aktori> Aktoret { get; set; }

        public Zhanri Zhanri { get; set; }

        public string AktoretString { 
            get
            {
                string lista = "";
                foreach (var item in Aktoret)
                    lista += $"{item.Emri} {item.Mbiemri};";


                //for (int i = 0; i < Aktoret.Count; i++)
                //{
                //    lista += $"{Aktoret[i].Emri} {Aktoret[i].Mbiemri};";
                //}
                return lista;
            }
        
        }

    }
}
