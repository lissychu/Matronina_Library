using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matronina_Library
{
    public partial class RentedBooksForm : Form
    {
        public RentedBooksForm()
        {
            InitializeComponent();
        }

        private void RentedBooksForm_Load(object sender, EventArgs e)
        {
            RentedBooksList.Columns[0].Width = 75;
            RentedBooksList.Columns[1].Width = 200;
            RentedBooksList.Columns[2].Width = 75;
            RentedBooksList.Columns[3].Width = 150;
            RentedBooksList.Columns[4].Width = 250;
            RentedBooksList.Columns[5].Width = 150;
            RentedBooksList.Columns[6].Width = 150;


            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("MatroninaLibraryRent.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('/');

                string[] arr = new string[7];
                ListViewItem itm;
                arr[0] = tokens[0];
                arr[1] = tokens[1];
                arr[2] = tokens[2];
                arr[3] = tokens[3];
                arr[4] = tokens[4];
                arr[5] = tokens[5];
                arr[6] = tokens[6];
                itm = new ListViewItem(arr);
                RentedBooksList.Items.Add(itm);
            }

            file.Close();
        }
    }
}
