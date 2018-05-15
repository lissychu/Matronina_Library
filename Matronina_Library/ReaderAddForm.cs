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
    public partial class ReaderAddForm : Form
    {
        public ReaderAddForm()
        {
            InitializeComponent();
        }

        public ReaderAddForm(string[] reader)
        {
            InitializeComponent();
            this.Text = "О читателе";

            InputLibraryCard.Text = reader[0];
            InputLibraryCard.ReadOnly = true;

            InputNameSurname.Text = reader[1];
            InputNameSurname.ReadOnly = true;

            InputReaderAddress.Text = reader[2];
            InputReaderAddress.ReadOnly = true;

            InputReaderPhone.Text = reader[3];
            InputReaderPhone.ReadOnly = true;

            ButtonSaveReaderAdd.Visible = false;

        }

        private void ButtonSaveReaderAdd_Click(object sender, EventArgs e)
        {
            string librarycard = InputLibraryCard.Text;
            string namesurname = InputNameSurname.Text;
            string readeraddress = InputReaderAddress.Text;
            string readerphone = InputReaderPhone.Text;
            string result = librarycard + "/" + namesurname + "/" + readeraddress + "/" + readerphone;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("MatroninaLibraryReaders.txt", true))
            {
                file.WriteLine(result);
            }
            this.Close();
        }
    }
}
