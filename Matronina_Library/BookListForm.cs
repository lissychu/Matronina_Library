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
    public partial class BookListForm : Form
    {
        private List<string[]> BookListArray = new List<string[]>();

        public BookListForm()
        {
            InitializeComponent();
        }

        private void ButtonBookAdd_Click(object sender, EventArgs e)
        {
            BookAddForm frm = new BookAddForm();
            frm.Show();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateItems();
        }

        private void UpdateItems()
        {
            BookList.Items.Clear();
            this.BookListArray.Clear();

            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("MatroninaLibraryBooks.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('/');

                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = tokens[0];
                arr[1] = tokens[1];
                arr[2] = tokens[2];
                itm = new ListViewItem(arr);
                BookList.Items.Add(itm);

                this.BookListArray.Add(tokens);
            }

            file.Close();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            BookList.Columns[0].Width = 100;
            BookList.Columns[1].Width = 235;
            BookList.Columns[2].Width = 421;

            this.UpdateItems();
        }

        private void BookList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BookList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = BookList.SelectedItems;
                ListViewItem.ListViewSubItemCollection lvItem = items[0].SubItems;

                string id = lvItem[0].Text;

                var itemBook = this.BookListArray.Find(item => item[0] == id);

                BookAddForm frm = new BookAddForm(itemBook);
                frm.Show();
            }
        }
    }
}
