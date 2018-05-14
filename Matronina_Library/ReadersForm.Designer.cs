namespace Matronina_Library
{
    partial class ReadersForm
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
            this.ButtonReaderAdd = new System.Windows.Forms.Button();
            this.ReadersList = new System.Windows.Forms.ListView();
            this.ColumnCardNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnNameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonReaderListUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonReaderAdd
            // 
            this.ButtonReaderAdd.Location = new System.Drawing.Point(26, 417);
            this.ButtonReaderAdd.Name = "ButtonReaderAdd";
            this.ButtonReaderAdd.Size = new System.Drawing.Size(752, 23);
            this.ButtonReaderAdd.TabIndex = 0;
            this.ButtonReaderAdd.Text = "Добавить читателя";
            this.ButtonReaderAdd.UseVisualStyleBackColor = true;
            this.ButtonReaderAdd.Click += new System.EventHandler(this.ButtonReaderAdd_Click);
            // 
            // ReadersList
            // 
            this.ReadersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCardNumber,
            this.ColumnNameSurname});
            this.ReadersList.Location = new System.Drawing.Point(26, 10);
            this.ReadersList.Name = "ReadersList";
            this.ReadersList.Size = new System.Drawing.Size(747, 361);
            this.ReadersList.TabIndex = 1;
            this.ReadersList.UseCompatibleStateImageBehavior = false;
            this.ReadersList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnCardNumber
            // 
            this.ColumnCardNumber.Text = "№ билета";
            this.ColumnCardNumber.Width = 100;
            // 
            // ColumnNameSurname
            // 
            this.ColumnNameSurname.Text = "ФИО читателя";
            this.ColumnNameSurname.Width = 600;
            // 
            // ButtonReaderListUpdate
            // 
            this.ButtonReaderListUpdate.Location = new System.Drawing.Point(26, 385);
            this.ButtonReaderListUpdate.Name = "ButtonReaderListUpdate";
            this.ButtonReaderListUpdate.Size = new System.Drawing.Size(748, 26);
            this.ButtonReaderListUpdate.TabIndex = 2;
            this.ButtonReaderListUpdate.Text = "Обновить";
            this.ButtonReaderListUpdate.UseVisualStyleBackColor = true;
            this.ButtonReaderListUpdate.Click += new System.EventHandler(this.ButtonReaderListUpdate_Click);
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReaderListUpdate);
            this.Controls.Add(this.ReadersList);
            this.Controls.Add(this.ButtonReaderAdd);
            this.Name = "ReadersForm";
            this.Text = "Наши читатели";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonReaderAdd;
        private System.Windows.Forms.ListView ReadersList;
        private System.Windows.Forms.ColumnHeader ColumnCardNumber;
        private System.Windows.Forms.ColumnHeader ColumnNameSurname;
        private System.Windows.Forms.Button ButtonReaderListUpdate;
    }
}