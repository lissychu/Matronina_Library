namespace Matronina_Library
{
    partial class RentedBooksForm
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
            this.RentedBooksList = new System.Windows.Forms.ListView();
            this.LibraryCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RentedBooksList
            // 
            this.RentedBooksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LibraryCard,
            this.NameSurname,
            this.BookCode,
            this.Author,
            this.BookName,
            this.RentDate,
            this.RentEndDate});
            this.RentedBooksList.Location = new System.Drawing.Point(12, 12);
            this.RentedBooksList.Name = "RentedBooksList";
            this.RentedBooksList.Size = new System.Drawing.Size(1062, 426);
            this.RentedBooksList.TabIndex = 0;
            this.RentedBooksList.UseCompatibleStateImageBehavior = false;
            this.RentedBooksList.View = System.Windows.Forms.View.Details;
            // 
            // LibraryCard
            // 
            this.LibraryCard.Text = "№ билета";
            // 
            // NameSurname
            // 
            this.NameSurname.Text = "ФИО читателя";
            // 
            // BookCode
            // 
            this.BookCode.Text = "Код книги";
            // 
            // Author
            // 
            this.Author.Text = "Автор";
            // 
            // BookName
            // 
            this.BookName.Text = "Название книги";
            // 
            // RentDate
            // 
            this.RentDate.Text = "Книга выдана";
            // 
            // RentEndDate
            // 
            this.RentEndDate.Text = "Необходимо вернуть до";
            // 
            // RentedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.RentedBooksList);
            this.Name = "RentedBooksForm";
            this.Text = "Выданные книги";
            this.Load += new System.EventHandler(this.RentedBooksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RentedBooksList;
        private System.Windows.Forms.ColumnHeader LibraryCard;
        private System.Windows.Forms.ColumnHeader NameSurname;
        private System.Windows.Forms.ColumnHeader BookCode;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader RentDate;
        private System.Windows.Forms.ColumnHeader RentEndDate;
    }
}