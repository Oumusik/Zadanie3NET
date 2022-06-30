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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Szczegóły.xaml
    /// </summary>
    public partial class Szczegóły : Window
    {
        Film film { get; set; }
        ListFilm lista { get; set; }
        public Szczegóły(Film film)
        {
            this.film = film;
            DataContext = film;
            InitializeComponent();
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            lista.ListaFilmów.Add(film);
            Close();
        }
    }
}
