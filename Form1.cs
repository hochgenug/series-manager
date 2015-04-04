using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace SeriesManager
{
    partial class Form1 : Form
    {
        public class infos
        {
            private string _source;
            private string _seriePath;
            private string _mangaPath;

            List<string> _listSeries = new List<string>();
            List<string> _listMangas = new List<string>();

            public infos()
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

        infos informations = new infos();

        public Form1()
        {
            InitializeComponent();
            this.label_DefaultDownload.Text = this.label_DefaultDownload.Text + this.informations.source;
            this.reloadList();
        }

        private void Form1_Load(object sender, EventArgs e){}

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = informations.source;
            fbd.Description = "Merci de choisir un new folder :)";

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                informations.source = fbd.SelectedPath;
                label_DefaultDownload.Text = "Current download folder : " + informations.source;
            }
            this.reloadList();
        }
        
        private void btn_move_Click(object sender, EventArgs e)
        {
            this.moveFiles();
            this.reloadList();
        }

        private void reloadList()
        {
            lb_filesToMove.Items.Clear();
            var files = Directory.EnumerateFiles(informations.source, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".avi") || s.EndsWith(".mp4") || s.EndsWith(".mkv"));

            List<string> Series = informations.listSeries;
            List<string> Mangas = informations.listMangas;

            string serieName;
            foreach (string file in files)
            {
                serieName = file.Replace('.', ' ').ToLower();

                foreach (string Serie in Series)
                {
                    if (serieName.Contains(Serie))
                    {
                        lb_filesToMove.Items.Add(file);
                    }
                }
            }
        }

        private void link_checkAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < lb_filesToMove.Items.Count; i++)
                lb_filesToMove.SetItemChecked(i, true); ;
        }

        private void moveFiles()
        {
            List<string> Series = informations.listSeries;
            List<string> Mangas = informations.listMangas;
            string serieName;

            foreach (object itemChecked in lb_filesToMove.CheckedItems)
            {
                System.Text.RegularExpressions.Regex myRegex = new Regex(@"^(.*)S(?<saison>[\d]{2})E(?<episode>[\d]{2})(.*)$");
                GroupCollection groups = myRegex.Match(itemChecked.ToString()).Groups;
                foreach (string Serie in Series)
                {
                    serieName = itemChecked.ToString().Replace('.', ' ').ToLower();
                    if (serieName.Contains(Serie))
                    {
                        string from = itemChecked.ToString();
                        string name = Serie;
                        string ext = Path.GetExtension(from);

                        string to = informations.seriePath + "\\" + Serie + "\\";
                        if (groups["saison"].ToString() != "")
                        {
                            to += "S" + groups["saison"].ToString().TrimStart('0') + "\\";
                            name += " S" + groups["saison"];

                            if (Directory.Exists(to) == false)
                            {
                                DirectoryInfo di = Directory.CreateDirectory(to);
                            }
                        }
                        name += "E" + groups["episode"];

                        to += UppercaseFirst(name) + ext;

                        Debug.WriteLine(from);
                        Debug.WriteLine(to);
                        File.Move(from, to);
                    }
                }
            }
        }
    }
}
