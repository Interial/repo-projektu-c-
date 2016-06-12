using System;

using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<Pacjent> PacjentList { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            
            PacjentList = new ObservableCollection<Pacjent>();
            this.RezBox.ItemsSource = Enum.GetValues(typeof(Rezonans.Dostepny));
            this.SpecComboBox.ItemsSource = Enum.GetValues(typeof(Lekarz.Specjalizacja));
            this.StatusComboBox.ItemsSource = Enum.GetValues(typeof(Status));
            this.StatusComboBox.SelectedIndex = 0;
           
        }
 private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            
            string Imie = this.textBox1.Text;
            string Nazwisko = this.textBox2.Text;
            string Pesel = this.textBox3.Text;
            string Nr_id = this.textBox4.Text;
            Status Status = (Status)Enum.Parse(typeof(Status), this.StatusComboBox.Text);
            Pacjent Pacjent = new Pacjent(Imie, Nazwisko, Pesel, Nr_id, Status);
            
            
            PacjentList.Add(Pacjent);
           
        }

 private void Button_Click_1(object sender, RoutedEventArgs e)
 {
     string Nazwisko = this.Search.Text;
     foreach(Pacjent p in PacjentList){
         if(p.Nazwisko == Nazwisko)
         {
             Imie_s_v.Content = p.Imie;
             Nazwisko_s_v.Content = p.Nazwisko;
             Pesel_s_v.Content = p.Pesel;
             ID_s_v.Content = p.Nr_id;
             Status_s_v.Content = p.Status;
         }
     }
 }

      
    }
}
