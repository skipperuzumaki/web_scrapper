using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchBox.Text = "Search for Movies or Tv Shows";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = SearchBox.Text;
            File.WriteAllText(".\\searchphrase.txt", search);
            System.Diagnostics.Process.Start(".\\search.py");
            System.Threading.Thread.Sleep(5000);
            List<List<string>> movies = new List<List<string>>();
            List<List<string>> tv = new List<List<string>>();
            string moviedata = File.ReadAllText(".\\movies.csv");
            string tvdata = File.ReadAllText(".\\tv.csv");
            foreach (string row in moviedata.Split('\n'))
            {
                var value = row.Split('|');
                List<string> movie = new List<string>();
                movie.AddRange(value);
                movies.Add(movie);
            }
            foreach (string row in tvdata.Split('\n'))
            {
                var value = row.Split('|');
                List<string> t = new List<string>();
                t.AddRange(value);
                tv.Add(t);
            }
            MovieDisplay md = new MovieDisplay();
        }
    }
}
