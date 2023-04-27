using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Aktori
    {
        public int Id { get; set; }

        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        void test()
        {


        }

        public override string ToString()
        {
            return $"{Id}:-> Emri: {Emri}  {Mbiemri}";
        }
    }
}
