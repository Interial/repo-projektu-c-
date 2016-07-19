using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface KluczoweFunkcje
    {
        void changeStatus(Status nowyStatus);
    }
    public class Czlowiek : KluczoweFunkcje
    {
        protected string imie { get; set; }
        protected string nazwisko { get; set; }
        protected string pesel { get; set; }
        protected string nr_id { get; set; }
        protected Status status { get; set; }

        public string Imie
        {
            get {return imie;}
            set {imie = value;}
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }
        public string Nr_id
        {
            get { return nr_id; }
            set { nr_id = value; }
        }
        public Status _Status
        {
            get { return status; }
            set { status = value; }
        }

        public Czlowiek(string i, string n, string p, string nr, Status s)
        {
            imie = i;
            nazwisko = n;
            pesel = p;
            nr_id = nr;
            status = s;
        }

        public Czlowiek()
        {

        }

        public virtual void changeStatus(Status nowyStatus)
        {
            status = nowyStatus;
        }

        public void sprawdzPesel()
        {
            if (pesel.Length != 11)
                throw new WyjatekPesel("zla ilosc znakow");
        }

    }

    public class Pacjent : Czlowiek
    {
        protected string ostatniaWizyta { get; set; }
        protected string choroba { get; set; }

        public string OstatniaWizyta
        {
            get { return ostatniaWizyta; }
            set { ostatniaWizyta = value; }
        }

        public string Choroba
        {
            get { return choroba; }
            set { choroba = value; }
        }

        public Pacjent(string i, string n, string p, string nr, Status s, string ow, string c)
        {
            imie = i;
            nazwisko = n;
            pesel = p;
            nr_id = nr;
            status = s;
            ostatniaWizyta = ow;
            choroba = c;
        }

        public override void changeStatus(Status nowyStatus)
        {
            Console.WriteLine("Zmieniono status pacjenta");
            base.changeStatus(nowyStatus);
        }
    }

    public class Lekarz : Czlowiek
    {
        protected string ostatniUrlop { get; set; }
        protected string specjalizacja { get; set; }

        public string OstatniUrlop
        {
            get { return ostatniUrlop; }
            set { ostatniUrlop = value; }
        }

        public string Specjalizacja
        {
            get { return specjalizacja; }
            set { specjalizacja = value; }
        }

        public Lekarz(string i, string n, string p, string nr, Status s, string ou, string spec)
        {
            imie = i;
            nazwisko = n;
            pesel = p;
            nr_id = nr;
            status = s;
            ostatniUrlop = ou;
            specjalizacja = spec;
        }

        public override void changeStatus(Status nowyStatus)
        {
            Console.WriteLine("Zmieniono status lekarza");
            base.changeStatus(nowyStatus);
        }
    }

    public class Funkcyjny : Czlowiek
    {
        protected string obslugiwanePietro { get; set; }
        protected Personel funkcja { get; set; }

        public Funkcyjny(string i, string n, string p, string nr, Status s, string op, Personel f)
        {
            imie = i;
            nazwisko = n;
            pesel = p;
            nr_id = nr;
            status = s;
            obslugiwanePietro = op;
            funkcja = f;
        }

        public override void changeStatus(Status nowyStatus)
        {
            Console.WriteLine("Zmieniono status funkcyjnego");
            base.changeStatus(nowyStatus);
        }
    }

    public class WyjatekPesel : Exception
    {
        public WyjatekPesel(string message) :
            base("bledny pesel: " + message) { }
    }

    public enum Status { Student, Uczeń, Bezrobotny, Emeryt, Pracujący}
    public enum Personel {Pielegniarz, Pielegniarka, Sprzatajacy}
}
