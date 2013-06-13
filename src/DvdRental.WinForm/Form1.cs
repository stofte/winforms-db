using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DvdRental.Core.Components;
using DvdRental.Core.Models;

namespace DvdRental.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateListBox(IEnumerable<Dvd> dvds)
        {
            titleListBox.Items.Clear();

            foreach (var dvd in dvds)
            {
                titleListBox.Items.Add(dvd);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListBox(Database.Query<Dvd>());
        }

         private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleListBox_DoubleClick(object sender, EventArgs e)
        {
            var dvd = titleListBox.SelectedItem as Dvd;
            var dvdEditForm = new EditDvdWin();
            dvdEditForm.Execute(dvd);
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dvdEditForm = new EditDvdWin();
            var dvd = new Dvd();
            dvd.SetId();
            dvdEditForm.Execute(dvd);
            Form1_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dvds = Database.Query<Dvd>().Where(dvd => dvd.Search(searchText.Text));
            PopulateListBox(dvds);
        }
    }
}
