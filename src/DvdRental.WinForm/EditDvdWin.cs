using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DvdRental.Core.Components;
using DvdRental.Core.Models;


namespace DvdRental.WinForm
{
    public partial class EditDvdWin : Form
    {


        public void BuildGenreBox()
        {
            genreBox.Items.Clear();
            foreach (var genre in Database.Query<Genre>())
            {
                genreBox.Items.Add(genre);
            }
            genreBox.SelectedIndex = 0;
        }

        
        public EditDvdWin()
        {
            InitializeComponent();
        }

        private void EditDvdWin_Load(object sender, EventArgs e)
        {

        }

        public void Execute(Dvd dvd)
        {
            BuildGenreBox();

            titleEdit.Text = dvd.Title;
            yearEdit.Text = dvd.ReleaseYear.ToString();
            genreBox.Text = dvd.Genre.ToString();
            descriptionBox.Text = dvd.Description;
            DvdImageBox.Image = dvd.GetPoster();

            var x = this.ShowDialog();
            if (x == System.Windows.Forms.DialogResult.OK)
            {
                dvd.Title = titleEdit.Text;
                dvd.ReleaseYear = int.Parse(yearEdit.Text);
                if (genreBox.SelectedItem == null)
                {

                    var genre = new Genre()
                    {
                        Id = Database.GetNextID<Genre>(),
                        Name = genreBox.Text
                    };
                    Database.Session.Insert(genre);
                    dvd.Genre = genre.Id;
                }
                else
                {
                    var genre = genreBox.SelectedItem as Genre;
                    dvd.Genre = genre.Id;
                }
                
                dvd.Description = descriptionBox.Text;
                dvd.SetPoster(DvdImageBox.Image);
                if (dvd.IsNew)
                {
                    Database.Insert(dvd);
                }
                else
                {
                    Database.Session.Update(dvd);
                }
            }
        }

        private void DvdImageBox_Click(object sender, EventArgs e)
        {
            var result = OpenDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                Image image = Image.FromFile(OpenDialog1.FileName);

                DvdImageBox.Image = image;
            }

        }
    }
}
