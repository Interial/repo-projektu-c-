using System;

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Czlowiek> ListaOsob;
        public MainWindow()
        {
            InitializeComponent();
            ListaOsob = new List<Czlowiek>();

            this.StatusComboBox.ItemsSource = Enum.GetValues(typeof(Status));
            this.StatusComboBox.SelectedIndex = 0;
        }
        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {

            string imie = this.textBox1.Text;
            string nazwisko = this.textBox2.Text;
            string pesel = this.textBox3.Text;
            string nr_id = this.textBox4.Text;
            Status status = (Status)Enum.Parse(typeof(Status), this.StatusComboBox.Text);
            Czlowiek osoba = new Czlowiek(imie, nazwisko, pesel, nr_id, status);
            try
            {
                osoba.sprawdzPesel();
            }
            catch (WyjatekPesel exc)
            {
                Label.Content = exc.Message;
            }
            finally
            {

            }
            ListaOsob.Add(osoba);

        }

        private void Pokaz_Click(object sender, RoutedEventArgs e)
        {
            string Nazwisko = this.Search.Text;
            foreach (Czlowiek c in ListaOsob.ToArray())
            {
                if (c.Nazwisko.Equals(Nazwisko))
                {
                    Imie_s_v.Content = c.Imie;
                    Nazwisko_s_v.Content = c.Nazwisko;
                    Pesel_s_v.Content = c.Pesel;
                    ID_s_v.Content = c.Nr_id;
                    Status_s_v.Content = c._Status;
                }
            }
        }



    }
}
