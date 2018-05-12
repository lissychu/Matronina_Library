namespace Matronina_Library
{
    partial class BookAddForm
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
            this.Author = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.BookYear = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.Annotation = new System.Windows.Forms.Label();
            this.InputAuthor = new System.Windows.Forms.TextBox();
            this.InputBookName = new System.Windows.Forms.TextBox();
            this.InputBookYear = new System.Windows.Forms.TextBox();
            this.InputBookPrice = new System.Windows.Forms.TextBox();
            this.InputBookAnnotation = new System.Windows.Forms.TextBox();
            this.ButtonSaveBookAdd = new System.Windows.Forms.Button();
            this.BookCode = new System.Windows.Forms.Label();
            this.InputBookCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(57, 64);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(37, 13);
            this.Author.TabIndex = 0;
            this.Author.Text = "Автор";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(57, 103);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(89, 13);
            this.BookName.TabIndex = 1;
            this.BookName.Text = "Название книги";
            // 
            // BookYear
            // 
            this.BookYear.AutoSize = true;
            this.BookYear.Location = new System.Drawing.Point(57, 141);
            this.BookYear.Name = "BookYear";
            this.BookYear.Size = new System.Drawing.Size(70, 13);
            this.BookYear.TabIndex = 2;
            this.BookYear.Text = "Год издания";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Location = new System.Drawing.Point(57, 176);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(33, 13);
            this.BookPrice.TabIndex = 3;
            this.BookPrice.Text = "Цена";
            // 
            // Annotation
            // 
            this.Annotation.AutoSize = true;
            this.Annotation.Location = new System.Drawing.Point(57, 217);
            this.Annotation.Name = "Annotation";
            this.Annotation.Size = new System.Drawing.Size(61, 13);
            this.Annotation.TabIndex = 4;
            this.Annotation.Text = "Аннотация";
            // 
            // InputAuthor
            // 
            this.InputAuthor.Location = new System.Drawing.Point(163, 64);
            this.InputAuthor.Name = "InputAuthor";
            this.InputAuthor.Size = new System.Drawing.Size(597, 20);
            this.InputAuthor.TabIndex = 5;
            // 
            // InputBookName
            // 
            this.InputBookName.Location = new System.Drawing.Point(163, 103);
            this.InputBookName.Name = "InputBookName";
            this.InputBookName.Size = new System.Drawing.Size(597, 20);
            this.InputBookName.TabIndex = 6;
            // 
            // InputBookYear
            // 
            this.InputBookYear.Location = new System.Drawing.Point(163, 141);
            this.InputBookYear.Name = "InputBookYear";
            this.InputBookYear.Size = new System.Drawing.Size(100, 20);
            this.InputBookYear.TabIndex = 7;
            // 
            // InputBookPrice
            // 
            this.InputBookPrice.Location = new System.Drawing.Point(163, 176);
            this.InputBookPrice.Name = "InputBookPrice";
            this.InputBookPrice.Size = new System.Drawing.Size(175, 20);
            this.InputBookPrice.TabIndex = 8;
            // 
            // InputBookAnnotation
            // 
            this.InputBookAnnotation.Location = new System.Drawing.Point(163, 217);
            this.InputBookAnnotation.Multiline = true;
            this.InputBookAnnotation.Name = "InputBookAnnotation";
            this.InputBookAnnotation.Size = new System.Drawing.Size(597, 151);
            this.InputBookAnnotation.TabIndex = 9;
            // 
            // ButtonSaveBookAdd
            // 
            this.ButtonSaveBookAdd.Location = new System.Drawing.Point(60, 405);
            this.ButtonSaveBookAdd.Name = "ButtonSaveBookAdd";
            this.ButtonSaveBookAdd.Size = new System.Drawing.Size(700, 28);
            this.ButtonSaveBookAdd.TabIndex = 10;
            this.ButtonSaveBookAdd.Text = "Сохранить";
            this.ButtonSaveBookAdd.UseVisualStyleBackColor = true;
            this.ButtonSaveBookAdd.Click += new System.EventHandler(this.ButtonSaveBookAdd_Click);
            // 
            // BookCode
            // 
            this.BookCode.AutoSize = true;
            this.BookCode.Location = new System.Drawing.Point(57, 36);
            this.BookCode.Name = "BookCode";
            this.BookCode.Size = new System.Drawing.Size(58, 13);
            this.BookCode.TabIndex = 11;
            this.BookCode.Text = "Код книги";
            // 
            // InputBookCode
            // 
            this.InputBookCode.Location = new System.Drawing.Point(163, 36);
            this.InputBookCode.Name = "InputBookCode";
            this.InputBookCode.Size = new System.Drawing.Size(255, 20);
            this.InputBookCode.TabIndex = 12;
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputBookCode);
            this.Controls.Add(this.BookCode);
            this.Controls.Add(this.ButtonSaveBookAdd);
            this.Controls.Add(this.InputBookAnnotation);
            this.Controls.Add(this.InputBookPrice);
            this.Controls.Add(this.InputBookYear);
            this.Controls.Add(this.InputBookName);
            this.Controls.Add(this.InputAuthor);
            this.Controls.Add(this.Annotation);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookYear);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Name = "BookAddForm";
            this.Text = "Добавить новую книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label BookYear;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.Label Annotation;
        private System.Windows.Forms.TextBox InputAuthor;
        private System.Windows.Forms.TextBox InputBookName;
        private System.Windows.Forms.TextBox InputBookYear;
        private System.Windows.Forms.TextBox InputBookPrice;
        private System.Windows.Forms.TextBox InputBookAnnotation;
        private System.Windows.Forms.Button ButtonSaveBookAdd;
        private System.Windows.Forms.Label BookCode;
        private System.Windows.Forms.TextBox InputBookCode;
    }
}