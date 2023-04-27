using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FilmLibrary
{
    public class Libraria
    {
        List<Filmi> lista;
        string fajlli = "filmat.json";

        public Libraria()
        {
            MbushListenMeFilmaNgaJson();
        }

        public Libraria(List<Filmi> filmat)
        {
            lista = filmat;
        }

        void MbushListenMeFilmaNgaJson()
        {
            string json = File.ReadAllText(fajlli);
            lista = JsonConvert.DeserializeObject<List<Filmi>>(json);
        }
        
        public void RuajFilmatNeJson()
        {
            string json = JsonConvert.SerializeObject(lista);
            File.WriteAllText(fajlli, json);
        }

        // lexo listen me aktore nga nje fajll JSON
        public List<Aktori> ListaMeAktore()
        {
            //
            return new List<Aktori>();

        }

        // lexo listen me filma nga nje fajll JSON
        public List<Filmi> ListaMeFilma()
        {
            //
            return lista;
        }
        
        // ruaje nje film te ri ne fajll 
        public void RuajeFilmin(Filmi filmi)
        {
            //
            lista.Add(filmi);
        }


    }
}
