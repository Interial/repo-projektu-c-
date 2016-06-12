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

            this.StatusComboBox.ItemsSource = Enum.GetValues(typeof(Status));
            this.StatusComboBox.SelectedIndex = 0;
        }
 private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            
            string Imie = this.textBox1.Text;
            string Nazwisko = this.textBox2.Text;
            int Pesel = int.Parse(this.textBox3.Text);
            int Nr_id = int.Parse(this.textBox4.Text);
            Status Status = (Status)Enum.Parse(typeof(Status), this.StatusComboBox.Text);
            Pacjent Pacjent = new Pacjent(Imie, Nazwisko, Pesel, Nr_id, Status);

            PacjentList.Add(Pacjent);
           
        }


             
    }
}
