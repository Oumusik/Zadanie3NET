using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Tytuł"] = new string[] { "TytułRok", "FormatListy" },
            ["Reżyser"] = new string[] { "TytułRok", "FormatListy" },
            ["DataWydania"] = new string[] {"Wiek", "FormatListy"}
        };
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (relatedProperties.ContainsKey(propertyName))
                foreach (string relatedProperty in relatedProperties[propertyName])
                    OnPropertyChanged(relatedProperty);
        }

        static uint następneID = 0;
        
        string samochod, kierowca;
        string tytuł, reżyser, studio, nośnik;
        DateTime? dataWydania = null;
        DateTime? rok = null,zakończenie = null;

        public string Samochod
        {
            get => samochod;
            set
            {
                samochod = value;
                OnPropertyChanged();
            }
        }
        public string Kierowca
        {
            get => kierowca;
            set
            {
                kierowca = value;
                OnPropertyChanged();
            }
        }
        public string Tytuł
        {
            get => tytuł;
            set
            {
                tytuł = value;
                OnPropertyChanged();
            }
        }
        public string Reżyser
        {
            get => reżyser;
            set
            {
                reżyser = value;
                OnPropertyChanged();
            }
        }
        public string Studio
        {
            get => studio;
            set
            {
                studio = value;
                OnPropertyChanged();
            }
        }

        public string Nośnik
        {
            get => nośnik;
            set
            {
                nośnik = value;
                OnPropertyChanged();
            }
        }
        public string Wiek
        {
            get
            {
                if (dataWydania != null)
                {
                    return dataWydania.ToString();
                }
                else
                    return "Null exception";
            }
        }
        public DateTime? Rok
        {
            get => rok;
            set
            {
                rok = value;
                OnPropertyChanged();
            }
        }
        public DateTime? Zakończenie
        {
            get => zakończenie;
            set
            {
                zakończenie = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }
        public string TytułRok { get => $"{tytuł}, {dataWydania.ToString()}"; }
        public string FormatListy { get => $"Tytuł:  {tytuł}, Reżyser  {reżyser},Studio: {studio},Nośnik: {nośnik},Data Wydania: {dataWydania.ToString()}"; }
        public uint ID { get; } = następneID++;
        public string FormatID { get => "ID: " + ID; }
    }
}
