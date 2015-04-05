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
        Betaserie bs = new Betaserie();
              
        Infos informations = new Infos();

        public Form1()
        {
            InitializeComponent();
            this.label_DefaultDownload.Text = this.label_DefaultDownload.Text + informations.source;
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

            if (lb_filesToMove.Items.Count == 0)
            {
                this.label_checklist.Show();
            }
            else
            {
                this.label_checklist.Hide();
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

            this.progressBar.Minimum = 1;
            this.progressBar.Maximum = lb_filesToMove.CheckedItems.Count + 1;
            this.progressBar.Value = 1;
            this.progressBar.Step = 1;

            foreach (object itemChecked in lb_filesToMove.CheckedItems)
            {
                System.Text.RegularExpressions.Regex myRegex = new Regex(@"^(.*)S(?<saison>[\d]{2})E(?<episode>[\d]{2})(.*)$");
                GroupCollection groups = myRegex.Match(itemChecked.ToString()).Groups;
                foreach (string Serie in Series) //refaire meme traitement pour serie youhou
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

                        File.Move(from, to);
                        this.progressBar.PerformStep();
                    }
                }
            }
        }
    }
}
