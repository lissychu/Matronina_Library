namespace Matronina_Library
{
    partial class BookListForm
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
            this.ButtonBookAdd = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListView();
            this.ColumnBookCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnBookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBookAdd
            // 
            this.ButtonBookAdd.Location = new System.Drawing.Point(15, 412);
            this.ButtonBookAdd.Name = "ButtonBookAdd";
            this.ButtonBookAdd.Size = new System.Drawing.Size(763, 28);
            this.ButtonBookAdd.TabIndex = 0;
            this.ButtonBookAdd.Text = "Добавить новую книгу";
            this.ButtonBookAdd.UseVisualStyleBackColor = true;
            this.ButtonBookAdd.Click += new System.EventHandler(this.ButtonBookAdd_Click);
            // 
            // BookList
            // 
            this.BookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnBookCode,
            this.ColumnBookAuthor,
            this.ColumnBookName});
            this.BookList.Location = new System.Drawing.Point(15, 12);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(763, 356);
            this.BookList.TabIndex = 1;
            this.BookList.UseCompatibleStateImageBehavior = false;
            this.BookList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnBookCode
            // 
            this.ColumnBookCode.Text = "Код книги";
            // 
            // ColumnBookAuthor
            // 
            this.ColumnBookAuthor.Text = "ФИО Автора";
            // 
            // ColumnBookName
            // 
            this.ColumnBookName.Text = "Название книги";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(15, 379);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(762, 24);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.ButtonBookAdd);
            this.Name = "BookListForm";
            this.Text = "Список книг";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBookAdd;
        private System.Windows.Forms.ListView BookList;
        private System.Windows.Forms.ColumnHeader ColumnBookCode;
        private System.Windows.Forms.ColumnHeader ColumnBookAuthor;
        private System.Windows.Forms.ColumnHeader ColumnBookName;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}