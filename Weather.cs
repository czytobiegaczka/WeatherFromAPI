using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFromAPI
{
    
    class Weather
    {
        public string Time { get; private set; }
        public string Name { get; private set; }
        public string Temp { get; set; }
        /*
        public string TempMin { get; private set; }
        public string TempMax { get; private set; }
        public string Wind { get; private set; }
        public string Cloud { get; private set; }
        public string Pressure { get; private set; }
        */

        public string tekst;

        public Weather(string time,string name,string temp)
        {
            Time = time;
            Name = name;
            Temp = temp;
            /*
            TempMin = tempmin;
            TempMax = tempmax;
            Wind = wind;
            Cloud = cloud;
            Pressure = preassure;
            */
            tekst = Time+" "+Name+" "+Temp;
        }


    }
}
