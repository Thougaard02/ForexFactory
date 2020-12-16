using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForexFactory
{
    class JSONReader
    {
        public string Output()
        {
            WebClient client = new WebClient();

            //Downloads the requuested resource as a string
            string rawJsson = client.DownloadString("https://cdn-nfs.faireconomy.media/ff_calendar_thisweek.json?version=0b818dbbcd7aa9b9f980488109a5cf6c");
            //Deserialize JSON object
            List<ForexFactoryElements> items = JsonConvert.DeserializeObject<List<ForexFactoryElements>>(rawJsson);

            //Empty string
            string temp = "";

            //Count items
            for (int i = 0; i < items.Count; i++)
            {
                //If impact is high
                if (items[i].Impact == "High")
                {
                    //Sets temp to be item.Title, Items.Country, Items.Date, Items.Impact, Items.Forecast and Items.Previous
                    temp += $"Title {items[i].Title}\n" +
                        $"Country {items[i].Country}\n" +
                        $"Date {items[i].Date}\n" +
                        $"Impact {items[i].Impact}\n" +
                        $"Forecast {items[i].Forecast}\n" +
                        $"Previous {items[i].Previous}\n" +
                        $"\n";
                }
            }
            //returning temp
            return temp;
        }
    }
}
