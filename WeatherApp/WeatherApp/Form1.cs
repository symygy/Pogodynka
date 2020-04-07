using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WeatherApp.ServiceReference;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Windows;

namespace WeatherApp
{
    public partial class Weather : Form
    {
        const string APIKey = "xxx";
        int kod_pogodyAktualna;
        int[] kod_pogodyPrognoza = new int[3]; // pobiera informacje na temat aktualnej pogody by wyswietlic ikone

        float[] min = new float[3];
        float[] max = new float[3];

        float[] temperatura = new float[30];
        private object daneWyjsciowe;

        public Weather()
        {
            InitializeComponent();
            //Parametry startowe
            textBox1.Text = "Kraków";
            wypelnijTablice();
            
        }

        public void wypelnijTablice()
        {
            for (int i = 0; i < 3; i++)
            {
                min[i] = 100;
                max[i] = -100;
            }
        }

        //Do poprawy
        public void wczytajMiasta()
        {
            using (StreamReader r = new StreamReader("../citylist.json"))
            {
                var json = r.ReadToEnd();
                //var wynik = JsonConvert.DeserializeObject<ListaMiast.Miasta>(json);

                var wynik = JsonConvert.DeserializeObject<List<ListaMiast.Miasta>>(json);
                List<ListaMiast.Miasta> lista = wynik;
                
                
            }
        }
       
        // Funkcja odpowiedzialna za wyświetlone symbole pogody
        public void WyswObrazka(int kod, ImageList lista, PictureBox obrazek)
        {
            if (kod >= 200 && kod < 233) obrazek.Image = lista.Images[6];
            if ((kod >= 300 && kod < 322) || (kod >= 511 && kod < 532)) obrazek.Image = lista.Images[4];
            if (kod >= 500 && kod < 505) obrazek.Image = lista.Images[5];
            if (kod >= 600 && kod < 623) obrazek.Image = lista.Images[7];
            if (kod >= 701 && kod < 782) obrazek.Image = lista.Images[8];
            if (kod == 800) obrazek.Image = lista.Images[0];
            if (kod == 801) obrazek.Image = lista.Images[1];
            if (kod == 802) obrazek.Image = lista.Images[2];
            if ((kod == 803) || (kod == 804)) obrazek.Image = lista.Images[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AktualnaPogoda();
            PrognozaPogody();
            WyswObrazka(kod_pogodyAktualna, imagelist1, pbChmury);
            WyswObrazka(kod_pogodyPrognoza[0], imagelist2, pbDzien1);
            WyswObrazka(kod_pogodyPrognoza[1], imagelist2, pbDzien2);
            WyswObrazka(kod_pogodyPrognoza[2], imagelist2, pbDzien3);
        }

        // Pokazanie aktualnej pogody
        public void AktualnaPogoda()
        {
                WebClient web = new WebClient(); 
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&lang=pl" + "&appid={0}" +"&units=metric", APIKey);

                var json = web.DownloadString(url);
                var wynik = JsonConvert.DeserializeObject<PogodaInfo.Rootobject>(json);
                PogodaInfo.Rootobject daneWyjsciowe = wynik;

            lblMiasto.Text = string.Format("{0}", daneWyjsciowe.name);
            lblKraj.Text = string.Format("{0}", daneWyjsciowe.sys.country);
            lblTemp.Text = string.Format("{0}" + " C", daneWyjsciowe.main.temp);
            lblCisnienie.Text = string.Format("{0}" + " hPa", daneWyjsciowe.main.pressure);
            lblWilgotnosc.Text = string.Format("{0}" + " %", daneWyjsciowe.main.humidity);
            
            lblWschod.Text = string.Format("{0}", daneWyjsciowe.sys.sunrise);
            lblZachod.Text = string.Format("{0}", daneWyjsciowe.sys.sunset);
            lblOpis.Text = string.Format("{0}", daneWyjsciowe.weather[0].description);

            //Wyswietla aktualny kod pogody do weryfikacji poprawnosci dzialania
            lblTest.Text = string.Format("{0}", daneWyjsciowe.weather[0].id);
            ////////////////////////////////

            //Pobiera kod aktualnej pogody
            kod_pogodyAktualna = Convert.ToInt32(daneWyjsciowe.weather[0].id);
        }

        //Funkcja wyświetlająca dane pogodowe z kolejnych dni
        // idDnia - oznacza dzien odczytany z pliku json
        // numerDnia - oznacza numer dnia do wyswietlenia
        public void Oblicz(int a, int b, int idDnia, int numerDnia, GroupBox dzien, Forecast.Rootobject obiekt)
        {
            
            //Wyznaczanie najnizszej i nawyzszej temp w ciagu doby
            for (int i = a; i < b; i++)
            {
                if (max[numerDnia-1] < temperatura[i]) max[numerDnia - 1] = temperatura[i];
                if (min[numerDnia-1] > temperatura[i]) min[numerDnia - 1] = temperatura[i];
            }

            //wypelnianie pol z odpowiednim tagiem
            foreach (Control pole in dzien.Controls)
            {
                Convert.ToString(numerDnia); //zmiana numeru dnia na string

                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "dt" + numerDnia) pole.Text = string.Format("{0}" + " C", obiekt.list[idDnia].main.temp);
                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "dc" + numerDnia) pole.Text = string.Format("{0}" + " hPa", obiekt.list[idDnia].main.pressure);
                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "dw" + numerDnia) pole.Text = string.Format("{0}" + " %", obiekt.list[idDnia].main.humidity);
                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "dtmin" + numerDnia) pole.Text = string.Format("{0}" + " C", min[numerDnia - 1]);
                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "dtmax" + numerDnia) pole.Text = string.Format("{0}" + " C", max[numerDnia - 1]);
                if (pole.GetType() == typeof(Label) && Convert.ToString(pole.Tag) == "do" + numerDnia) pole.Text = string.Format("{0}", obiekt.list[idDnia].weather[0].description);
            }
        }
        
    // Prognoza pogody na kolejne 5 dni
    public void PrognozaPogody()
        {
            WebClient web = new WebClient();
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q=" + textBox1.Text + "&lang=pl" + "&appid={0}" + "&units=metric", APIKey);

            var json = web.DownloadString(url);
            var wynik = JsonConvert.DeserializeObject<Forecast.Rootobject>(json);
            Forecast.Rootobject daneWyjsciowe = wynik;

            //Przypisanie kodu pogody do kolejnych 3 dni 
            // Indeks 5, 13, 21 wynika z kolejnych 3 dni o godzinie 12:00
            kod_pogodyPrognoza[0] = Convert.ToInt32(daneWyjsciowe.list[0].weather[0].id);
            kod_pogodyPrognoza[1] = Convert.ToInt32(daneWyjsciowe.list[8].weather[0].id);
            kod_pogodyPrognoza[2] = Convert.ToInt32(daneWyjsciowe.list[16].weather[0].id);

            //Testowanie poprawnosci wyswietlenia kodow pogody
            lblTestD1.Text = string.Format("{0}", daneWyjsciowe.list[0].weather[0].id);
            lblTestD2.Text = string.Format("{0}", daneWyjsciowe.list[8].weather[0].id);
            lblTestD3.Text = string.Format("{0}", daneWyjsciowe.list[16].weather[0].id);

            //Zapis wartosci temperatury w zaleznosci od godziny w ciagu 3 dni (pomiar co 3h)
            for (int i = 0; i < 25; i++)
            {
                temperatura[i] = daneWyjsciowe.list[i].main.temp;
            }

            //Oblicza pogode dla kolejnych 3 dni
            Oblicz(0, 9, 0, 1, gbDzien1, daneWyjsciowe);
            Oblicz(8, 17, 8, 2, gbDzien2, daneWyjsciowe);
            Oblicz(16, 25, 16, 3, gbDzien3, daneWyjsciowe); 
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AktualnaPogoda();
            PrognozaPogody();
            WyswObrazka(kod_pogodyAktualna, imagelist1, pbChmury);
            WyswObrazka(kod_pogodyPrognoza[0], imagelist2, pbDzien1);
            WyswObrazka(kod_pogodyPrognoza[1], imagelist2, pbDzien2);
            WyswObrazka(kod_pogodyPrognoza[2], imagelist2, pbDzien3);
        }

       
    }
}
