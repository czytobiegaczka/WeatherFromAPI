using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WeatherFromAPI
{
    
    public partial class Form1 : Form
        {
        public string xxx;
        public string yyy;
        public string zzz;
        public string tempmin;
        public string tempmax;
        public string wind;
        public string cloud;
        public string preassure;
        public string tekst = "";


        public Form1()
        {
            InitializeComponent();
            LoadWeather();
        }

        private void LoadWeather()
        {
            //throw new NotImplementedException();
            /*
            XmlDocument doc = new XmlDocument();

            doc.Load("c:\\xxx\\pogodapl.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes[3].ChildNodes)
            {
                //string time = node.Attributes[0].Value;
                //Console.WriteLine(node.Attributes["value"].Value + ": " + node.Attributes["number"].Value);
                string time = node.Attributes["value"].Value;
                string name = node.Attributes["number"].Value;
                string temp = node.FirstChild.NextSibling.FirstChild.InnerText;
                string tempmin = node.FirstChild.NextSibling.LastChild.InnerText;
                string tempmax = node.ChildNodes[2].InnerText;
                string wind = node.FirstChild.NextSibling.FirstChild.InnerText;
                string cloud = node.FirstChild.NextSibling.LastChild.InnerText;
                string preassure = node.ChildNodes[2].InnerText;

                listBox.Items.Add(new Weather(time,name,temp,tempmin,tempmax,wind,cloud,preassure));
            }
            */

            //komen
            Weather weather1 = new Weather("czas", "nazwa", "temperatura");
            weather1.tekst = "inna nazwa";

            int licz = 0;
            int liczx = 0;
            int liczy = 0;
            int liczz = 0;

            prognoza dzis = new prognoza();
            
            XmlReader xmlRreader = XmlReader.Create(@"c:\xxx\pogodapl.xml");

            while (xmlRreader.Read())
            {
                if (xmlRreader.NodeType == XmlNodeType.Element)
                {
                    switch (xmlRreader.Name)
                    {
                        case "time":
                            dzis.time.Add(xmlRreader.GetAttribute("from"));
                            break;
                        case "symbol":
                            dzis.symbol.Add(xmlRreader.GetAttribute("name"));
                            break;
                        case "precipitation":
                            if(xmlRreader.HasAttributes)
                            {
                                dzis.deszcz.Add(xmlRreader.GetAttribute("type"));
                            }
                            else
                            {
                                dzis.deszcz.Add("brak opadów");
                            }
                            
                            break;
                        case "humidity":
                            dzis.wilgotnosc.Add(xmlRreader.GetAttribute("value"));
                            break;
                    }
                }

            }

            dzis.show();

            /*
                while (xmlRreader.Read())
            {


                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "time")) //wartość dla daty i godziny 
                {
                    if (xmlRreader.HasAttributes)
                    {
                        xxx = xmlRreader.GetAttribute("from");
                        liczx++;
                        //tabPogoda[licznik, 0] = time;

                        //Console.WriteLine(xmlRreader.GetAttribute("from"));

                    }

 

                }

                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "symbol")) // wartość dla opisu pogody
                {
                    if (xmlRreader.HasAttributes)
                    {
                        yyy = xmlRreader.GetAttribute("name");
                        liczy++;

                        //tabPogoda[licznik, 1] = name;
                        //Console.WriteLine(xmlRreader.GetAttribute("number") + ": " + xmlRreader.GetAttribute("name"));
                    }
                }

                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "temperature")) // wartość dla temperatury
                {
                    if (xmlRreader.HasAttributes)
                    {
                        zzz = xmlRreader.GetAttribute("value");
                        tempmin = xmlRreader.GetAttribute("min");
                        tempmax = xmlRreader.GetAttribute("max");
                        liczz++;
                        //tabPogoda[licznik, 2] = temp;
                        //tabPogoda[licznik, 3] = tempmin;
                        //tabPogoda[licznik, 4] = tempmax;
                        //Console.WriteLine(xmlRreader.GetAttribute("value") + ": " + xmlRreader.GetAttribute("min") + ": " + xmlRreader.GetAttribute("max"));
                    }
                }

                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "windDirection")) //wartość dla wiatru
                {
                    if (xmlRreader.HasAttributes)
                    {
                        wind = xmlRreader.GetAttribute("name");
                        //tabPogoda[licznik, 5] = wind;
                        //Console.WriteLine(xmlRreader.GetAttribute("name"));
                    }
                }

                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "pressure")) //wartość dla wiatru
                {
                    if (xmlRreader.HasAttributes)
                    {
                        preassure = xmlRreader.GetAttribute("value");
                        //tabPogoda[licznik, 6] = preassure;
                        //Console.WriteLine(xmlRreader.GetAttribute("value"));
                    }
                }

                if ((xmlRreader.NodeType == XmlNodeType.Element) && (xmlRreader.Name == "clouds")) //wartość dla wiatru
                {
                    if (xmlRreader.HasAttributes)
                    {
                        cloud = xmlRreader.GetAttribute("value");
                        //tabPogoda[licznik, 7] = cloud;
                        //Console.WriteLine(xmlRreader.GetAttribute("value"));
                    }
                }


                tekst = tekst + xxx;
                

            }

            */
            //label7.Text = tekst;
            //weather1.tekst = yyy;
            //label7.Text = liczx.ToString() + " " + liczy.ToString() + " " + liczz.ToString() + " " + licz.ToString();
            //List<Weather> pogody = new List<Weather>();


            /*
                            this.Controls.Add(listView);
                ListViewItem lvi = new ListViewItem(tabPogoda[0,0]);

                    for (int i=1; i<=licznik; i++)
                {
                    lvi.SubItems.Add(tabPogoda[i,1]);
                    lvi.SubItems.Add(tabPogoda[i, 2]);
                    lvi.SubItems.Add(tabPogoda[i, 3]);
                    lvi.SubItems.Add(tabPogoda[i, 4]);
                    lvi.SubItems.Add(tabPogoda[i, 5]);
                    lvi.SubItems.Add(tabPogoda[i, 6]);
                    lvi.SubItems.Add(tabPogoda[i, 7]);
                }

                //listBox.Items.Add(new Weather(time, name, temp, tempmin, tempmax, wind, cloud, preassure));

    */


        }


    }
}