using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovieDisplay : Form
    {
        private int i = 0;
        private bool mov = true;
        private List<List<string>> movies;
        private List<List<string>> tv;

        public MovieDisplay(List<List<string>> movies, List<List<string>> tv)
        {
            InitializeComponent();
            this.movies = movies;
            this.tv = tv;
        }

        private void MovieDisplay_Load(object sender, EventArgs e)
        {
            if (mov)
            {
                Header.Text = "Movies";
                TV.Text = "TV Shows";
                Title.Text = movies[i][0];
                Release.Text = movies[i][1];
                Summary.Text = movies[i][4];
                Cover.Image = Image.FromFile("movies\\" + i + ".jpg");
            }
            else
            {
                Header.Text = "Tv";
                TV.Text = "Movies";
                Title.Text = tv[i][0];
                Release.Text = tv[i][1];
                Summary.Text = tv[i][4];
                Cover.Image = Image.FromFile("tv\\" + i + ".jpg");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (mov)
            {
                i = i + 1;
                if (i >= movies.Count()-1)
                {
                    i = i - 1;
                }
                this.MovieDisplay_Load(sender, e);
            }
            else
            {
                i = i + 1;
                if (i >= tv.Count()-1)
                {
                    i = i - 1;
                }
                this.MovieDisplay_Load(sender, e);
            }
        }

        private void TV_Click(object sender, EventArgs e)
        {
            if (mov)
            {
                mov = false;
            }
            else
            {
                mov = true;
            }
            i = 0;
            this.MovieDisplay_Load(sender, e);
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (mov)
            {
                i = i - 1;
                if (i < 0)
                {
                    i = i + 1;
                }
                this.MovieDisplay_Load(sender, e);
            }
            else
            {
                i = i - 1;
                if (i < 0)
                {
                    i = i + 1;
                }
                this.MovieDisplay_Load(sender, e);
            }
        }

        private void Visit_Click(object sender, EventArgs e)
        {
            if (mov)
            {
                System.Diagnostics.Process.Start(movies[i][2]);
            }
            else
            {
                System.Diagnostics.Process.Start(tv[i][2]);
            }
        }
    }
}
