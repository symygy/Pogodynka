using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class ListaMiast
    {
        public class Miasta
        {
            public int id { get; set; }
            public string name { get; set; }
            public float lon { get; set; }
            public float lat { get; set; }
            public int country { get; set; }
            public List<Miasta> Cities { get; set; }

        }
    }
}
