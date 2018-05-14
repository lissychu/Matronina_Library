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
