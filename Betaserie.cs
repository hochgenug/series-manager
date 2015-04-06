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
            // IEnumerable<dynamic> test = getSerieEpisodes(getSeriesId("The Walking Dead"));
            getEpisodeName("The Walking Dead", "2", "3");

        }

        private string getEpisodeName(string serieName, string season, string episode){
            string episodeName = "";
            IEnumerable<dynamic> episodesList = getSerieEpisodes(getSeriesId(serieName));
            foreach (var item in episodesList)
            {
                if (item.season == season && item.episode == episode)
                {
                    episodeName = item.title;
                }
            }

            Console.WriteLine(episodeName);
            return episodeName;
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

            return episodes;
        }

        private int getSeriesId(string name)
        {
            int serieId = 0;
            StreamReader r = new StreamReader("c:\\series.json");// TODO
            string json = r.ReadToEnd();
            JObject seriesList = JObject.Parse(json);

           var series =
           from se in seriesList["shows"]
           select new
           {
               title = (string)se["title"],
               id = (int)se["id"]
           };

           foreach (var item in series)
            {
                 if (item.title == name)
                 {
                     serieId = item.id;
                     break;
                 }
             }

           return serieId;
        }

    }
}
