using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_domowee
{
 
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaMagazynowa = new ObservableCollection<Produkt>();
        private int licznikId = 1;

        public MainWindow()
        {
            InitializeComponent();
           
            Lista_Magazynowa.ItemsSource = ListaMagazynowa;
        }
        
   

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Przycisk_Click(object sender, RoutedEventArgs e)
        {
            string PobieranieEan = WpisanieEan.Text;
            String pobieranieTekstu = WpisanieNazwy.Text;
            int PobieranieIlosci = (int)WpisanieIlosci.Value;
            string PobieranieKategori = WpisanieKategori.Text;
            string PobieranieLokalizacji = WpisanieLokalizacji.Text;

            Produkt Nowe = new Produkt
            {
                id = licznikId++,
                Ean = PobieranieEan,
                Nazwa = pobieranieTekstu,
                Ilosc = PobieranieIlosci,
                Kategoria = PobieranieKategori,
                Lokalizacja = PobieranieLokalizacji
           };
            ListaMagazynowa.Add(Nowe);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WpisanieKategori_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WpisanieLokalizacji_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WpisanieIlosci_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
    public class Produkt
    {
        public int id { get; set; }
        public String Ean { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public String Kategoria { get; set; }
        public String Lokalizacja { get; set; }

    }
}