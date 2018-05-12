namespace Matronina_Library
{
    partial class MenuForm
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
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ButtonBookList = new System.Windows.Forms.Button();
            this.ButtonBooksRented = new System.Windows.Forms.Button();
            this.ButtonReaders = new System.Windows.Forms.Button();
            this.ButtonRentABook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(38, 404);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(728, 34);
            this.ButtonAbout.TabIndex = 0;
            this.ButtonAbout.Text = "О Библиотеке";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonBookList
            // 
            this.ButtonBookList.Location = new System.Drawing.Point(38, 124);
            this.ButtonBookList.Name = "ButtonBookList";
            this.ButtonBookList.Size = new System.Drawing.Size(728, 57);
            this.ButtonBookList.TabIndex = 1;
            this.ButtonBookList.Text = "Список книг";
            this.ButtonBookList.UseVisualStyleBackColor = true;
            this.ButtonBookList.Click += new System.EventHandler(this.ButtonBookList_Click);
            // 
            // ButtonBooksRented
            // 
            this.ButtonBooksRented.Location = new System.Drawing.Point(38, 213);
            this.ButtonBooksRented.Name = "ButtonBooksRented";
            this.ButtonBooksRented.Size = new System.Drawing.Size(728, 60);
            this.ButtonBooksRented.TabIndex = 2;
            this.ButtonBooksRented.Text = "Выданные книги";
            this.ButtonBooksRented.UseVisualStyleBackColor = true;
            this.ButtonBooksRented.Click += new System.EventHandler(this.ButtonBooksRented_Click);
            // 
            // ButtonReaders
            // 
            this.ButtonReaders.Location = new System.Drawing.Point(38, 311);
            this.ButtonReaders.Name = "ButtonReaders";
            this.ButtonReaders.Size = new System.Drawing.Size(728, 60);
            this.ButtonReaders.TabIndex = 3;
            this.ButtonReaders.Text = "Наши читатели";
            this.ButtonReaders.UseVisualStyleBackColor = true;
            this.ButtonReaders.Click += new System.EventHandler(this.ButtonReaders_Click);
            // 
            // ButtonRentABook
            // 
            this.ButtonRentABook.Location = new System.Drawing.Point(38, 37);
            this.ButtonRentABook.Name = "ButtonRentABook";
            this.ButtonRentABook.Size = new System.Drawing.Size(728, 53);
            this.ButtonRentABook.TabIndex = 4;
            this.ButtonRentABook.Text = "Выдать книгу";
            this.ButtonRentABook.UseVisualStyleBackColor = true;
            this.ButtonRentABook.Click += new System.EventHandler(this.ButtonRentABook_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRentABook);
            this.Controls.Add(this.ButtonReaders);
            this.Controls.Add(this.ButtonBooksRented);
            this.Controls.Add(this.ButtonBookList);
            this.Controls.Add(this.ButtonAbout);
            this.Name = "MenuForm";
            this.Text = "Библиотека";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonBookList;
        private System.Windows.Forms.Button ButtonBooksRented;
        private System.Windows.Forms.Button ButtonReaders;
        private System.Windows.Forms.Button ButtonRentABook;
    }
}