using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ListFilm
    {

        public List<Film> ListaFilmów { get; set; } = new List<Film>(new Film[] {
            new Film() {
                Tytuł = "Harry Potter and Philosopher's Stone",
                Reżyser = "Chris Columbus",
                Studio = "Warner Bros.",
                Nośnik = "CD",
                DataWydania = DateTime.Parse("04.11.2001")
            },
        });

        internal void OtwórzSzczegóły(Film wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
        internal void DodajNowy()
        {
            Film nowa = new Film();
            ListaFilmów.Add(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();

        }
    }
}
