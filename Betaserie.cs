using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;


namespace SeriesManager
{
    class Betaserie
    {
        public const string API_URL = "http://api.betaseries.com/shows/episodes?v=2.4&id=";
        public const string API_KEY = "d563bc803eb8";

        public Betaserie()
        {
           getSerieEpisodes(10627);

           //getSerieEpisodes(getSeriesId("The Waling Dead"));
        }

        private string jsonResponse(int id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API_URL + id);
            request.Method = "GET";
            request.Headers["X-BetaSeries-Key"] = API_KEY;
            request.Headers["X-BetaSeries-Token"] = "";
            request.Accept = "Accept: application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return json;
        }

        private IEnumerable<dynamic> getSerieEpisodes(int SerieId)
        {
            JObject showEpisodes = JObject.Parse(jsonResponse(SerieId));
  
            var episodes =
            from ep in showEpisodes["episodes"]
            select new
            {
                title = (string)ep["title"],
                season = (string)ep["season"],
                episode = (string)ep["episode"]
            };

            /*foreach (var item in episodes)
            {
                Console.WriteLine(item.title);
            }*/

            return episodes;
        }

        private int getSeriesId(string name)
        {

            string SeriesList = SeriesManager.Series.Default.SeriesList;
            //TODO

            return 10627;
        }

    }
}
