namespace Matronina_Library
{
    partial class ReaderAddForm
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
            this.LibraryCard = new System.Windows.Forms.Label();
            this.NameSurname = new System.Windows.Forms.Label();
            this.ReaderAddress = new System.Windows.Forms.Label();
            this.ReaderPhone = new System.Windows.Forms.Label();
            this.InputLibraryCard = new System.Windows.Forms.TextBox();
            this.InputNameSurname = new System.Windows.Forms.TextBox();
            this.InputReaderAddress = new System.Windows.Forms.TextBox();
            this.InputReaderPhone = new System.Windows.Forms.TextBox();
            this.ButtonSaveReaderAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LibraryCard
            // 
            this.LibraryCard.AutoSize = true;
            this.LibraryCard.Location = new System.Drawing.Point(12, 37);
            this.LibraryCard.Name = "LibraryCard";
            this.LibraryCard.Size = new System.Drawing.Size(133, 13);
            this.LibraryCard.TabIndex = 0;
            this.LibraryCard.Text = "№ читательского билета";
            // 
            // NameSurname
            // 
            this.NameSurname.AutoSize = true;
            this.NameSurname.Location = new System.Drawing.Point(12, 69);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(34, 13);
            this.NameSurname.TabIndex = 1;
            this.NameSurname.Text = "ФИО";
            // 
            // ReaderAddress
            // 
            this.ReaderAddress.AutoSize = true;
            this.ReaderAddress.Location = new System.Drawing.Point(12, 105);
            this.ReaderAddress.Name = "ReaderAddress";
            this.ReaderAddress.Size = new System.Drawing.Size(38, 13);
            this.ReaderAddress.TabIndex = 2;
            this.ReaderAddress.Text = "Адрес";
            // 
            // ReaderPhone
            // 
            this.ReaderPhone.AutoSize = true;
            this.ReaderPhone.Location = new System.Drawing.Point(12, 138);
            this.ReaderPhone.Name = "ReaderPhone";
            this.ReaderPhone.Size = new System.Drawing.Size(103, 13);
            this.ReaderPhone.TabIndex = 3;
            this.ReaderPhone.Text = "Контактный номер";
            // 
            // InputLibraryCard
            // 
            this.InputLibraryCard.Location = new System.Drawing.Point(177, 30);
            this.InputLibraryCard.Name = "InputLibraryCard";
            this.InputLibraryCard.Size = new System.Drawing.Size(202, 20);
            this.InputLibraryCard.TabIndex = 4;
            // 
            // InputNameSurname
            // 
            this.InputNameSurname.Location = new System.Drawing.Point(177, 62);
            this.InputNameSurname.Name = "InputNameSurname";
            this.InputNameSurname.Size = new System.Drawing.Size(406, 20);
            this.InputNameSurname.TabIndex = 5;
            // 
            // InputReaderAddress
            // 
            this.InputReaderAddress.Location = new System.Drawing.Point(177, 98);
            this.InputReaderAddress.Name = "InputReaderAddress";
            this.InputReaderAddress.Size = new System.Drawing.Size(406, 20);
            this.InputReaderAddress.TabIndex = 6;
            // 
            // InputReaderPhone
            // 
            this.InputReaderPhone.Location = new System.Drawing.Point(177, 131);
            this.InputReaderPhone.Name = "InputReaderPhone";
            this.InputReaderPhone.Size = new System.Drawing.Size(406, 20);
            this.InputReaderPhone.TabIndex = 7;
            // 
            // ButtonSaveReaderAdd
            // 
            this.ButtonSaveReaderAdd.Location = new System.Drawing.Point(15, 188);
            this.ButtonSaveReaderAdd.Name = "ButtonSaveReaderAdd";
            this.ButtonSaveReaderAdd.Size = new System.Drawing.Size(568, 23);
            this.ButtonSaveReaderAdd.TabIndex = 8;
            this.ButtonSaveReaderAdd.Text = "Сохранить";
            this.ButtonSaveReaderAdd.UseVisualStyleBackColor = true;
            // 
            // ReaderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 223);
            this.Controls.Add(this.ButtonSaveReaderAdd);
            this.Controls.Add(this.InputReaderPhone);
            this.Controls.Add(this.InputReaderAddress);
            this.Controls.Add(this.InputNameSurname);
            this.Controls.Add(this.InputLibraryCard);
            this.Controls.Add(this.ReaderPhone);
            this.Controls.Add(this.ReaderAddress);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.LibraryCard);
            this.Name = "ReaderAddForm";
            this.Text = "Добавить нового читателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LibraryCard;
        private System.Windows.Forms.Label NameSurname;
        private System.Windows.Forms.Label ReaderAddress;
        private System.Windows.Forms.Label ReaderPhone;
        private System.Windows.Forms.TextBox InputLibraryCard;
        private System.Windows.Forms.TextBox InputNameSurname;
        private System.Windows.Forms.TextBox InputReaderAddress;
        private System.Windows.Forms.TextBox InputReaderPhone;
        private System.Windows.Forms.Button ButtonSaveReaderAdd;
    }
}