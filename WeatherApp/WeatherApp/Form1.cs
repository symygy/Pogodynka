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
        const string APIKey = "13d6178ceca4c4af84e3d0478b0a0fba";
        int kod_pogody; // pobiera informacje na temat aktualnej pogody by wyswietlic ikone
        float min1 = 100, max1 = -100;
        float min2 = 100, max2 = -100;
        float min3 = 100, max3 = -100;
        float[] temperatura = new float[30];

        public Weather()
        {
            InitializeComponent();
            //Parametry startowe
            textBox1.Text = "Kraków";
            
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
                
                //lblMiasto.Text = string.Format("{0}", );
                //cbMiasta.Items.AddRange(lista.ToArray());
            }
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

           
            kod_pogody = Convert.ToInt32(daneWyjsciowe.weather[0].id);

            //Wyświetlenie symbolu aktualnej pogody
            if (kod_pogody >= 200 && kod_pogody < 233) pbChmury.Image = imagelist1.Images[6];  
            if ((kod_pogody >= 300 && kod_pogody < 322) || (kod_pogody >= 511 && kod_pogody < 532)) pbChmury.Image = imagelist1.Images[4];
            if (kod_pogody >= 500 && kod_pogody < 505) pbChmury.Image = imagelist1.Images[5];
            if (kod_pogody >= 600 && kod_pogody < 623) pbChmury.Image = imagelist1.Images[7];
            if (kod_pogody >= 701 && kod_pogody < 782) pbChmury.Image = imagelist1.Images[8];
            if (kod_pogody == 800) pbChmury.Image = imagelist1.Images[0];
            if (kod_pogody == 801) pbChmury.Image = imagelist1.Images[1];
            if (kod_pogody == 802) pbChmury.Image = imagelist1.Images[2];
            if ((kod_pogody == 803) || (kod_pogody == 804)) pbChmury.Image = imagelist1.Images[3];
        }

        /* do przetestowania
        public void Oblicz(Control dzien)
        {
            for (int i = 0; i < 9; i++)
            {
                temperatura[i] = daneWyjsciowe.list[i].main.temp;

                if (max1 < temperatura[i]) max1 = temperatura[i];
                if (min1 > temperatura[i]) min1 = temperatura[i];
            }

            foreach (Control pole in dzien.Controls)
            {
                if (pole.Tag == "min") pole.Text = Convert.ToString(min1);
                if (pole.Tag == "max") pole.Text = Convert.ToString(max1);
            }
        }
        */


    // Prognoza pogody na kolejne 5 dni
    public void PrognozaPogody()
        {
            

            WebClient web = new WebClient();
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q=" + textBox1.Text + "&lang=pl" + "&appid={0}" + "&units=metric", APIKey);

            var json = web.DownloadString(url);
            var wynik = JsonConvert.DeserializeObject<Forecast.Rootobject>(json);
            Forecast.Rootobject daneWyjsciowe = wynik;

            //Wyznaczanie najnizszej i najwyzszej temp w ciagu doby
            for (int i = 0; i < 9; i++)
            { 
                temperatura[i] = daneWyjsciowe.list[i].main.temp;

                if (max1 < temperatura[i]) max1 = temperatura[i];
                if (min1 > temperatura[i]) min1 = temperatura[i];
            }

            //Wyswietlanie wynikow - dzien 1
            lblTemp1.Text = string.Format("{0}" + " C", daneWyjsciowe.list[5].main.temp);
            lblCisn1.Text = string.Format("{0}" + " hPa", daneWyjsciowe.list[5].main.pressure);
            lblWilg1.Text = string.Format("{0}" + " %", daneWyjsciowe.list[5].main.humidity);
            lblTMin1.Text = string.Format("{0}" + " C", min1);
            lblTMax1.Text = string.Format("{0}" + " C", max1);
            lblOpis1.Text = string.Format("{0}", daneWyjsciowe.list[5].weather[0].description);

            //Wyswietlanie wynikow - dzien 2
            for (int i = 8; i < 17; i++)
            {
                temperatura[i] = daneWyjsciowe.list[i].main.temp;

                if (max2 < temperatura[i]) max2 = temperatura[i];
                if (min2 > temperatura[i]) min2 = temperatura[i];
            }

            lblTemp2.Text = string.Format("{0}" + " C", daneWyjsciowe.list[13].main.temp);
            lblCisn2.Text = string.Format("{0}" + " hPa", daneWyjsciowe.list[13].main.pressure);
            lblWilg2.Text = string.Format("{0}" + " %", daneWyjsciowe.list[13].main.humidity);
            lblTMin2.Text = string.Format("{0}" + " C", min2);
            lblTMax2.Text = string.Format("{0}" + " C", max2);
            lblOpis2.Text = string.Format("{0}", daneWyjsciowe.list[13].weather[0].description);

            //Wyswietlanie wynikow - dzien 3
            for (int i = 16; i < 25; i++)
            {
                temperatura[i] = daneWyjsciowe.list[i].main.temp;

                if (max3 < temperatura[i]) max3 = temperatura[i];
                if (min3 > temperatura[i]) min3 = temperatura[i];
            }

            lblTemp3.Text = string.Format("{0}" + " C", daneWyjsciowe.list[21].main.temp);
            lblCisn3.Text = string.Format("{0}" + " hPa", daneWyjsciowe.list[21].main.pressure);
            lblWilg3.Text = string.Format("{0}" + " %", daneWyjsciowe.list[21].main.humidity);
            lblTMin3.Text = string.Format("{0}" + " C", min3);
            lblTMax3.Text = string.Format("{0}" + " C", max3);
            lblOpis3.Text = string.Format("{0}", daneWyjsciowe.list[21].weather[0].description);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AktualnaPogoda();
            PrognozaPogody();
        }

       
    }
}
