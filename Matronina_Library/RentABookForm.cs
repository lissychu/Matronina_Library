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
    public partial class RentABookForm : Form
    {
        private List<string[]> BookListArray = new List<string[]>();
        private List<string[]> ReadersListArray = new List<string[]>();

        public RentABookForm()
        {
            InitializeComponent();
        }

        private void RentABookForm_Load(object sender, EventArgs e)
        {
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("MatroninaLibraryBooks.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('/');

                this.BookListArray.Add(tokens);
            }

            file.Close();

            file = new System.IO.StreamReader("MatroninaLibraryReaders.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('/');

                this.ReadersListArray.Add(tokens);
            }

            file.Close();
        }

        private void InputLibraryCardNum_TextChanged(object sender, EventArgs e)
        {
            var itemReader = this.ReadersListArray.Find(item => item[0] == InputLibraryCardNum.Text);
    
            if (itemReader == null)
            {
                InputNameSurname.Text = "Читатель не найден";
            }
            else
            {
                InputNameSurname.Text = itemReader[1];
            }
        }

        private void InputBookCode_TextChanged(object sender, EventArgs e)
        {
            var itemBook = this.BookListArray.Find(item => item[0] == InputBookCode.Text);

            if (itemBook == null)
            {
                InputAuthor.Text = "Книга не найдена";
                InputBookName.Text = "Книга не найдена";
            }
            else
            {
                InputAuthor.Text = itemBook[1];
                InputBookName.Text = itemBook[2];
            }
        }

        private void ButtonSaveRentBook_Click(object sender, EventArgs e)
        {
            string librarycard = InputLibraryCardNum.Text;
            string namesurname = InputNameSurname.Text;
            string bookcode = InputBookCode.Text;
            string bookauthor = InputAuthor.Text;
            string bookname = InputBookName.Text;
            string rentdate = RentDate.Value.Date.ToString();
            string rentenddate = RentEndDate.Value.Date.ToString();

            string result = librarycard + "/" + namesurname + "/" + bookcode + "/" + bookauthor + "/" + bookname + "/" + rentdate + "/" + rentenddate;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("MatroninaLibraryRent.txt", true))
            {
                file.WriteLine(result);
            }
            this.Close();
        }
    }
}
