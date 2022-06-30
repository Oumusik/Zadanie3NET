using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         ListFilm model = new ListFilm();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox ListaFilmowa = (ListBox)parent.FindName("ListaDoWybrania");
            Film wybrany = (Film)ListaFilmowa.SelectedItem;
            if (wybrany != null)
                model.OtwórzSzczegóły(wybrany);
        }
        private void DodajNowy(object sender, RoutedEventArgs e)
        {
            model.DodajNowy();
        }
    }
}
