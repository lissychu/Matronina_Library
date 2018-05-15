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
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
        }

        public BookAddForm(string[] book)
        {
            InitializeComponent();
            this.Text = "О книге";

            InputBookCode.Text = book[0];
            InputBookCode.ReadOnly = true;

            InputAuthor.Text = book[1];
            InputAuthor.ReadOnly = true;

            InputBookName.Text = book[2];
            InputBookName.ReadOnly = true;

            InputBookYear.Text = book[3];
            InputBookYear.ReadOnly = true;

            InputBookPrice.Text = book[4];
            InputBookPrice.ReadOnly = true;

            InputBookAnnotation.Text = book[5];
            InputBookAnnotation.ReadOnly = true;

            ButtonSaveBookAdd.Visible = false;

        }

        private void ButtonSaveBookAdd_Click(object sender, EventArgs e)
        {
            string bookcode = InputBookCode.Text;
            string bookauthor = InputAuthor.Text;
            string bookname = InputBookName.Text;
            string bookyear = InputBookYear.Text;
            string bookprice = InputBookPrice.Text;
            string bookannotation = InputBookAnnotation.Text;
            string result = bookcode + "/" + bookauthor + "/" + bookname + "/" + bookyear + "/" + bookprice + "/" + bookannotation;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("MatroninaLibraryBooks.txt", true))
            {
                file.WriteLine(result);
            }
            this.Close();
        }
    }
}
