using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Pacjent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public int Pesel { get; set; }

        public int Nr_id { get; set; }

        public Status Status { get; set; }
        public Pacjent() { }
        public Pacjent(string Imie, string Nazwisko, int Pesel, int Nr_id, Status Status)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Pesel = Pesel;
            this.Nr_id = Nr_id;
            this.Status = Status;


        }
    }
    
    public enum Status { Student,Uczeń,Bezrobotny,Emeryt,Pracujący}
}
