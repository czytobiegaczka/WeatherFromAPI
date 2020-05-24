using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherFromAPI
{
    class prognoza
    {
        public List<string> time;
        public List<string> symbol;
        public List<string> deszcz;
        public List<string> wilgotnosc;

        public prognoza()
        {
            time = new List<string>();
            symbol = new List<string>();
            deszcz = new List<string>();
            wilgotnosc = new List<string>();
        }
        /*
        public void add_time(string _time)
        {
            time.Add(_time);
        }
        public void add_symbol(string _symbol)
        {
            symbol.Add(_symbol);
        }
        */

        public void show()

        {
            Console.WriteLine(time.Count + " " + symbol.Count + " " + deszcz.Count + " " + wilgotnosc.Count);
            for (int i = 0; i < time.Count && i < symbol.Count; i++)
            {
                Console.WriteLine(i + ". czas: " + time[i] + ", name: " + symbol[i] + ", deszcz: " + deszcz[i] + ", wilgotnosc: " + wilgotnosc[i]);
            }
        }

    }
}