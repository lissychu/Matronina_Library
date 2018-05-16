namespace Matronina_Library
{
    partial class RentABookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelLibraryCardNum = new System.Windows.Forms.Label();
            this.LabelNameSurname = new System.Windows.Forms.Label();
            this.InputLibraryCardNum = new System.Windows.Forms.TextBox();
            this.InputNameSurname = new System.Windows.Forms.TextBox();
            this.BookCode = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.RentEndDate = new System.Windows.Forms.DateTimePicker();
            this.DateRentBook = new System.Windows.Forms.Label();
            this.DateEndRentBook = new System.Windows.Forms.Label();
            this.InputAuthor = new System.Windows.Forms.TextBox();
            this.InputBookName = new System.Windows.Forms.TextBox();
            this.InputBookCode = new System.Windows.Forms.TextBox();
            this.ButtonSaveRentBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLibraryCardNum
            // 
            this.LabelLibraryCardNum.AutoSize = true;
            this.LabelLibraryCardNum.Location = new System.Drawing.Point(12, 68);
            this.LabelLibraryCardNum.Name = "LabelLibraryCardNum";
            this.LabelLibraryCardNum.Size = new System.Drawing.Size(95, 26);
            this.LabelLibraryCardNum.TabIndex = 0;
            this.LabelLibraryCardNum.Text = "№ читательского\r\nбилета";
            this.LabelLibraryCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNameSurname
            // 
            this.LabelNameSurname.AutoSize = true;
            this.LabelNameSurname.Location = new System.Drawing.Point(284, 68);
            this.LabelNameSurname.Name = "LabelNameSurname";
            this.LabelNameSurname.Size = new System.Drawing.Size(82, 13);
            this.LabelNameSurname.TabIndex = 1;
            this.LabelNameSurname.Text = "ФИО читателя";
            // 
            // InputLibraryCardNum
            // 
            this.InputLibraryCardNum.Location = new System.Drawing.Point(113, 68);
            this.InputLibraryCardNum.Name = "InputLibraryCardNum";
            this.InputLibraryCardNum.Size = new System.Drawing.Size(134, 20);
            this.InputLibraryCardNum.TabIndex = 2;
            this.InputLibraryCardNum.TextChanged += new System.EventHandler(this.InputLibraryCardNum_TextChanged);
            // 
            // InputNameSurname
            // 
            this.InputNameSurname.Location = new System.Drawing.Point(388, 68);
            this.InputNameSurname.Name = "InputNameSurname";
            this.InputNameSurname.Size = new System.Drawing.Size(401, 20);
            this.InputNameSurname.TabIndex = 3;
            // 
            // BookCode
            // 
            this.BookCode.AutoSize = true;
            this.BookCode.Location = new System.Drawing.Point(12, 147);
            this.BookCode.Name = "BookCode";
            this.BookCode.Size = new System.Drawing.Size(58, 13);
            this.BookCode.TabIndex = 4;
            this.BookCode.Text = "Код книги";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(284, 147);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(37, 13);
            this.Author.TabIndex = 5;
            this.Author.Text = "Автор";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(284, 181);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(89, 13);
            this.BookName.TabIndex = 6;
            this.BookName.Text = "Название книги";
            // 
            // RentDate
            // 
            this.RentDate.Location = new System.Drawing.Point(47, 291);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(200, 20);
            this.RentDate.TabIndex = 7;
            // 
            // RentEndDate
            // 
            this.RentEndDate.Location = new System.Drawing.Point(388, 291);
            this.RentEndDate.Name = "RentEndDate";
            this.RentEndDate.Size = new System.Drawing.Size(200, 20);
            this.RentEndDate.TabIndex = 8;
            // 
            // DateRentBook
            // 
            this.DateRentBook.AutoSize = true;
            this.DateRentBook.Location = new System.Drawing.Point(44, 243);
            this.DateRentBook.Name = "DateRentBook";
            this.DateRentBook.Size = new System.Drawing.Size(81, 13);
            this.DateRentBook.TabIndex = 9;
            this.DateRentBook.Text = "Книга выдана:";
            // 
            // DateEndRentBook
            // 
            this.DateEndRentBook.AutoSize = true;
            this.DateEndRentBook.Location = new System.Drawing.Point(385, 243);
            this.DateEndRentBook.Name = "DateEndRentBook";
            this.DateEndRentBook.Size = new System.Drawing.Size(146, 13);
            this.DateEndRentBook.TabIndex = 10;
            this.DateEndRentBook.Text = "Книгу необходимо вернуть:";
            // 
            // InputAuthor
            // 
            this.InputAuthor.Location = new System.Drawing.Point(388, 147);
            this.InputAuthor.Name = "InputAuthor";
            this.InputAuthor.Size = new System.Drawing.Size(401, 20);
            this.InputAuthor.TabIndex = 11;
            // 
            // InputBookName
            // 
            this.InputBookName.Location = new System.Drawing.Point(388, 178);
            this.InputBookName.Name = "InputBookName";
            this.InputBookName.Size = new System.Drawing.Size(401, 20);
            this.InputBookName.TabIndex = 12;
            // 
            // InputBookCode
            // 
            this.InputBookCode.Location = new System.Drawing.Point(113, 147);
            this.InputBookCode.Name = "InputBookCode";
            this.InputBookCode.Size = new System.Drawing.Size(134, 20);
            this.InputBookCode.TabIndex = 13;
            this.InputBookCode.TextChanged += new System.EventHandler(this.InputBookCode_TextChanged);
            // 
            // ButtonSaveRentBook
            // 
            this.ButtonSaveRentBook.Location = new System.Drawing.Point(15, 386);
            this.ButtonSaveRentBook.Name = "ButtonSaveRentBook";
            this.ButtonSaveRentBook.Size = new System.Drawing.Size(773, 45);
            this.ButtonSaveRentBook.TabIndex = 14;
            this.ButtonSaveRentBook.Text = "Сохранить";
            this.ButtonSaveRentBook.UseVisualStyleBackColor = true;
            this.ButtonSaveRentBook.Click += new System.EventHandler(this.ButtonSaveRentBook_Click);
            // 
            // RentABookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSaveRentBook);
            this.Controls.Add(this.InputBookCode);
            this.Controls.Add(this.InputBookName);
            this.Controls.Add(this.InputAuthor);
            this.Controls.Add(this.DateEndRentBook);
            this.Controls.Add(this.DateRentBook);
            this.Controls.Add(this.RentEndDate);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookCode);
            this.Controls.Add(this.InputNameSurname);
            this.Controls.Add(this.InputLibraryCardNum);
            this.Controls.Add(this.LabelNameSurname);
            this.Controls.Add(this.LabelLibraryCardNum);
            this.Name = "RentABookForm";
            this.Text = "Выдать книгу";
            this.Load += new System.EventHandler(this.RentABookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLibraryCardNum;
        private System.Windows.Forms.Label LabelNameSurname;
        private System.Windows.Forms.TextBox InputLibraryCardNum;
        private System.Windows.Forms.TextBox InputNameSurname;
        private System.Windows.Forms.Label BookCode;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker RentEndDate;
        private System.Windows.Forms.Label DateRentBook;
        private System.Windows.Forms.Label DateEndRentBook;
        private System.Windows.Forms.TextBox InputAuthor;
        private System.Windows.Forms.TextBox InputBookName;
        private System.Windows.Forms.TextBox InputBookCode;
        private System.Windows.Forms.Button ButtonSaveRentBook;
    }
}