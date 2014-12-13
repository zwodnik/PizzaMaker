using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PizzaMaker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        CPizza CPizzaObject;

        public MainPage()
        {
            this.InitializeComponent();
            CPizzaObject = new CPizza(CPizza.ENUMMnoznik.MALA);
            List<CSkladniki> skladniki = new List<CSkladniki>() {
                new CSkladniki() { Cena=1, Nazwa="pieczarki", UriMale = new Uri("ms-appx:///Assets/pieczarka_mini.png"), UriDuze = new Uri("ms-appx:///Assets/pieczarki.png")  },
                new CSkladniki() { Cena=1, Nazwa="ser", UriMale = new Uri("ms-appx:///Assets/ser_mini.png"), UriDuze = new Uri("ms-appx:///Assets/ser1.png")  },
                new CSkladniki() { Cena=2, Nazwa="boczek", UriMale = new Uri("ms-appx:///Assets/boczek_mini.png"), UriDuze = new Uri("ms-appx:///Assets/boczek.png")  },
                new CSkladniki() { Cena=1, Nazwa="oliwki", UriMale = new Uri("ms-appx:///Assets/oliwka_mini.png"), UriDuze = new Uri("ms-appx:///Assets/oliwki.png")  },
                new CSkladniki() { Cena=2, Nazwa="salami", UriMale = new Uri("ms-appx:///Assets/salami_mini.png"), UriDuze = new Uri("ms-appx:///Assets/salami.png")  },
                new CSkladniki() { Cena=3, Nazwa="kurczak", UriMale = new Uri("ms-appx:///Assets/kurczak_mini.png"), UriDuze = new Uri("ms-appx:///Assets/kurczak.png")  },
                new CSkladniki() { Cena=1, Nazwa="papryka", UriMale = new Uri("ms-appx:///Assets/papryka_mini.png"), UriDuze = new Uri("ms-appx:///Assets/papryka.png")  },
            };
            SkladnikiLV.ItemsSource = skladniki;

            pieczarki.Visibility = Visibility.Collapsed;
            ser.Visibility = Visibility.Collapsed;
            boczek.Visibility = Visibility.Collapsed;
            oliwki.Visibility = Visibility.Collapsed;
            salami.Visibility = Visibility.Collapsed;
            kurczak.Visibility = Visibility.Collapsed;
            papryka.Visibility = Visibility.Collapsed;  
            RadioMala.IsChecked = true;
        }

        private void Male_ciasto_checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            CPizzaObject.ZmianaPizzy(CPizza.ENUMMnoznik.MALA);
            TekstCeny.Text = "Cena całości: " + CPizzaObject.calkowity.ToString();
        }

        private void Srednie_ciasto_checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            CPizzaObject.ZmianaPizzy(CPizza.ENUMMnoznik.SREDNIA);
            TekstCeny.Text = "Cena całości: " + CPizzaObject.calkowity.ToString();
        }

        private void Duze_ciasto_checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            CPizzaObject.ZmianaPizzy(CPizza.ENUMMnoznik.DUZA);
            TekstCeny.Text = "Cena całości: " + CPizzaObject.calkowity.ToString();
        }


        private void Skladniki_changed_tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var item = (sender as ListView).SelectedItems;
            if (item != null)
            {

                 pieczarki.Visibility = Visibility.Collapsed;
            ser.Visibility = Visibility.Collapsed;
            boczek.Visibility = Visibility.Collapsed;
            oliwki.Visibility = Visibility.Collapsed;
            salami.Visibility = Visibility.Collapsed;
            kurczak.Visibility = Visibility.Collapsed;
            papryka.Visibility = Visibility.Collapsed;  

                int suma = 0;
                foreach (CSkladniki skadnik in item)
                {
                    suma += skadnik.Cena;
                    if (skadnik.Nazwa == "pieczarki") pieczarki.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "ser") ser.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "boczek") boczek.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "oliwki") oliwki.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "salami") salami.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "kurczak") kurczak.Visibility = Visibility.Visible;
                    if (skadnik.Nazwa == "papryka") papryka.Visibility = Visibility.Visible;

                }

                CPizzaObject.SumaSkladnikow = suma;
                CPizzaObject.f_calkowity(CPizzaObject.Podstawa);
                TekstCeny.Text = "Cena całości: " + CPizzaObject.calkowity.ToString();

                /*var item2 = (CSkladniki)item;
                CPizzaObject.SumaSkladnikow += item2.Cena;
                CPizzaObject.f_calkowity(CPizzaObject.Podstawa);
                TekstCeny.Text = "Cena całości: " + CPizzaObject.calkowity.ToString();*/
            }
        }
    }
}
