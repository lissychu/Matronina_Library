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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        private void ButtonBookList_Click(object sender, EventArgs e)
        {
            BookListForm frm = new BookListForm();
            frm.Show();
        }

        private void ButtonBooksRented_Click(object sender, EventArgs e)
        {
            BooksRentedForm frm = new BooksRentedForm();
            frm.Show();
        }

        private void ButtonReaders_Click(object sender, EventArgs e)
        {
            ReadersForm frm = new ReadersForm();
            frm.Show();
        }
    }
}
