using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SeriesManager
{
    class Infos
    {
        private string _source;
        private string _seriePath;
        private string _mangaPath;

        List<string> _listSeries = new List<string>();
        List<string> _listMangas = new List<string>();

        public Infos()
        {
            this.source = "D:\\Downloads";
            this._seriePath = "E:\\Serie";
            this._mangaPath = "E:\\Manga";

            string[] listSeries = Directory.GetDirectories(this._seriePath);
            string[] listMangas = Directory.GetDirectories(this._mangaPath);

            foreach (string serie in listSeries)
            {
                this._listSeries.Add(serie.Replace(this._seriePath + "\\", "").ToLower());
            }
            foreach (string manga in listMangas)
            {
                this.listMangas.Add(manga.Replace(this._mangaPath + "\\", "").ToLower());
            }
        }

        public string source
        {
            get { return _source; }
            set { _source = value; }
        }

        public string seriePath
        {
            get { return _seriePath; }
            set { _seriePath = value; }
        }

        public string mangaPath
        {
            get { return _mangaPath; }
            set { _mangaPath = value; }
        }

        public List<string> listSeries
        {
            get { return _listSeries; }
            set { _listSeries = value; }
        }

        public List<string> listMangas
        {
            get { return _listMangas; }
            set { _listMangas = value; }
        }
    }

}
