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
    public partial class ReadersForm : Form
    {
        private List<string[]> ReadersListArray = new List<string[]>();

        public ReadersForm()
        {
            InitializeComponent();
        }

        private void ButtonReaderAdd_Click(object sender, EventArgs e)
        {
            ReaderAddForm frm = new ReaderAddForm();
            frm.Show();
        }

        private void ButtonReaderListUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateItems();
        }
        private void UpdateItems()
        {
            ReadersList.Items.Clear();
            ReadersListArray.Clear();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("MatroninaLibraryReaders.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('/');

                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = tokens[0];
                arr[1] = tokens[1];
                itm = new ListViewItem(arr);
                ReadersList.Items.Add(itm);

                this.ReadersListArray.Add(tokens);
            }

            file.Close();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            ReadersList.Columns[0].Width = 100;
            ReadersList.Columns[1].Width = 650;

            this.UpdateItems();
        }

        private void ReadersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ReadersList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = ReadersList.SelectedItems;
                ListViewItem.ListViewSubItemCollection lvItem = items[0].SubItems;

                string id = lvItem[0].Text;

                var itemReader = this.ReadersListArray.Find(item => item[0] == id);

                ReaderAddForm frm = new ReaderAddForm(itemReader);
                frm.Show();
            }
        }
    }
}
