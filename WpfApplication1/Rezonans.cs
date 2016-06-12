using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Rezonans
    {
        public string Zlecony { get; set; }
        public Dostepny Dost {get; set;}
        public Rezonans(string Zlecony,  Dostepny Dostepny)
        {
            this.Zlecony = Zlecony;
            this.Dost = Dostepny;
        }
        public enum Dostepny { Tak, Nie }
    }
}
