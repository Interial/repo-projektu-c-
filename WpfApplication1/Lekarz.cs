using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Lekarz
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string Pesel { get; set; }

        public string Nr_id { get; set; }
        public Specjalizacja Specjalizacje { get; set; }
        public Lekarz(string Imie, string Nazwisko, string Pesel, string Nr_id, Specjalizacja Specjalizacje)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Pesel = Pesel;
            this.Nr_id = Nr_id;
            this.Specjalizacje = Specjalizacje;
            
        }
        public enum Specjalizacja {Internista,Chirurg,Onkolog,Urolog}
    }
}
